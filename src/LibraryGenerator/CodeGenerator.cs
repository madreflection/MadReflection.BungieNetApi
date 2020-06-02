using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Writers;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public class CodeGenerator
	{
		private readonly Dictionary<string, TypeBuilder> _generatedTypes = new Dictionary<string, TypeBuilder>();
		private readonly OpenApiDocument _openapi;
		private static readonly HashSet<string> _statsOperations = new HashSet<string>()
		{
			// There's no metadata in the JSON that indicates this so it's hard-coded here.
			"Destiny2.GetPostGameCarnageReport"
		};


		public CodeGenerator(OpenApiDocument openapi)
		{
			_openapi = openapi;
		}


		public void GenerateEntities(bool writeFiles)
		{
			foreach (var jsonTypeProperty in _openapi.Components.Schemas)
			{
				string @namespace = SplitNamespace(jsonTypeProperty.Key);
				string jsonTypeName = SplitTypeName(jsonTypeProperty.Key);
				string typeName = jsonTypeName;
				string typeDescription = jsonTypeProperty.Value.Description;

				TypeBuilder typeBuilder = null;

				string jsonType = jsonTypeProperty.Value.Type;

				if (jsonType == "integer")
				{
					var jsonValueObject = jsonTypeProperty.Value;

					if (jsonValueObject.Enum != null && jsonValueObject.Extensions.ContainsKey("x-enum-values"))
						typeBuilder = ProcessEnumType(jsonValueObject, @namespace, jsonTypeName, typeName, typeDescription);
				}
				else if (jsonType == "object")
				{
					var jsonValueObject = jsonTypeProperty.Value;

					if (jsonTypeProperty.Value.Extensions.TryGetValue("x-dictionary-key", out var dictionaryKeyTemp))
					{
						var dictionaryKey = TranslateDictionaryKeyExtensionToSchema(dictionaryKeyTemp);
						var dictionaryValue = jsonTypeProperty.Value.AdditionalProperties;
						typeBuilder = ProcessDictionaryType(jsonValueObject, dictionaryKey, dictionaryValue, @namespace, jsonTypeName, typeName, typeDescription);
					}
					else
					{
						typeBuilder = ProcessClassType(jsonValueObject, @namespace, jsonTypeName, typeName, typeDescription);
					}
				}

				if (typeBuilder != null)
					_generatedTypes.Add(TypeReference.ComponentsSchemasRootPath + jsonTypeProperty.Key, typeBuilder);
			}

			ResolveJsonPathTypeReferences();
			ResolveDefinitionBaseClass();

			var fileBuilders = (
				from typeBuilder in _generatedTypes.Select(x => x.Value)
				select new FileBuilder()
				{
					FolderPaths = typeBuilder.Namespace.Split('.'),
					FileName = typeBuilder.Name + ".cs",
					Builder = typeBuilder
				}).ToList();

			if (writeFiles)
				WriteEntityFiles(fileBuilders);
		}

		private void ResolveJsonPathTypeReferences()
		{
			List<(string, TypeBuilder)> fallbackTypes = new List<(string, TypeBuilder)>();

			foreach (var typeBuilder in _generatedTypes.Values)
			{
				if (typeBuilder is ClassBuilder classBuilder)
				{
					foreach (var propertyBuilder in classBuilder.Properties)
					{
						if (propertyBuilder.Type.IsJsonPath)
						{
							if (!_generatedTypes.TryGetValue(propertyBuilder.Type.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{propertyBuilder.Name}' with reference to unknown type '{propertyBuilder.Type.JsonPath}'.");

							propertyBuilder.Type = newTypeBuilder;
						}
						else if (propertyBuilder.Type.IsTypeBuilder)
						{
							if (propertyBuilder.Type.TypeBuilder is NullableEnumBuilder nullableEnumBuilder)
							{
								if (nullableEnumBuilder.EnumBuilder is AnonymousEnumBuilder anonEnumBuilder)
								{
									EnumBuilder enumBuilder = FindMatchingEnumBuilder(anonEnumBuilder);
									if (enumBuilder is null)
									{
										enumBuilder = new EnumBuilder()
										{
											Name = propertyBuilder.Name,
											JsonName = propertyBuilder.JsonName,
											Description = nullableEnumBuilder.Description,
											Namespace = "",
											IsFlags = anonEnumBuilder.IsFlags,
											UnderlyingType = anonEnumBuilder.UnderlyingType
										};
										enumBuilder.Fields.AddRange(anonEnumBuilder.Fields);

										fallbackTypes.Add((TypeReference.ComponentsSchemasRootPath + enumBuilder.Name, enumBuilder));
									}
									propertyBuilder.Type = new NullableEnumBuilder() { EnumBuilder = enumBuilder };
								}
								else
								{
									// OOPS!
								}
							}
							else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
							{
								EnumBuilder enumBuilder = FindMatchingEnumBuilder(anonEnumBuilder);
								if (enumBuilder is null)
								{
									enumBuilder = new EnumBuilder()
									{
										Name = propertyBuilder.Name,
										JsonName = propertyBuilder.JsonName,
										Description = typeBuilder.Description,
										Namespace = "",
										IsFlags = anonEnumBuilder.IsFlags,
										UnderlyingType = anonEnumBuilder.UnderlyingType
									};
									enumBuilder.Fields.AddRange(anonEnumBuilder.Fields);

									fallbackTypes.Add((TypeReference.ComponentsSchemasRootPath + enumBuilder.Name, enumBuilder));
								}
								propertyBuilder.Type = enumBuilder;
							}
							else
							{
								// OOPS!
							}
						}
						else
						{
							// OOPS!
						}
					}

					if (typeBuilder is DictionaryBuilder dictionaryBuilder)
					{
						if (dictionaryBuilder.KeyType.IsJsonPath)
						{
							if (!_generatedTypes.TryGetValue(dictionaryBuilder.KeyType.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{dictionaryBuilder.KeyType.Name}' with reference to unknown type '{dictionaryBuilder.KeyType.JsonPath}'.");

							dictionaryBuilder.KeyType = newTypeBuilder;
						}
						else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
						{
						}

						if (dictionaryBuilder.ItemType.IsJsonPath)
						{
							if (!_generatedTypes.TryGetValue(dictionaryBuilder.ItemType.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{dictionaryBuilder.ItemType.Name}' with reference to unknown type '{dictionaryBuilder.ItemType.JsonPath}'.");

							dictionaryBuilder.ItemType = newTypeBuilder;
						}
						else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
						{
						}
					}
				}
				else if (typeBuilder is ArrayBuilder arrayBuilder)
				{
					if (arrayBuilder.ElementType.IsJsonPath)
					{
						if (!_generatedTypes.TryGetValue(arrayBuilder.ElementType.JsonPath, out TypeBuilder newTypeBuilder))
							throw new Exception($"Type '{typeBuilder.Name}' has property '{arrayBuilder.ElementType.Name}' with reference to unknown type '{arrayBuilder.ElementType.JsonPath}'.");

						arrayBuilder.ElementType = newTypeBuilder;
					}
				}
			}

			foreach (var (name, builder) in fallbackTypes)
				_generatedTypes.Add(name, builder);
		}

		private void ResolveDefinitionBaseClass()
		{
			foreach (var (typeName, typeBuilder) in _generatedTypes)
			{
				if (typeName == TypeReference.ComponentsSchemasRootPath + "Destiny.Definitions.DestinyDefinition")
					continue;

				if (typeBuilder is ClassBuilder classBuilder)
				{
					var properties = classBuilder.Properties;

					var hashProperty = properties.Where(p => p.Type.Type == typeof(uint) && p.Name == "Hash").FirstOrDefault();
					var indexProperty = properties.Where(p => p.Type.Type == typeof(int) && p.Name == "Index").FirstOrDefault();
					var redactedProperty = properties.Where(p => p.Type.Type == typeof(bool) && p.Name == "Redacted").FirstOrDefault();

					if (hashProperty != null && indexProperty != null && redactedProperty != null)
					{
						properties.Remove(hashProperty);
						properties.Remove(indexProperty);
						properties.Remove(redactedProperty);
						classBuilder.BaseType = TypeReference.ComponentsSchemasRootPath + "Destiny.Definitions.DestinyDefinition";
					}
				}
			}
		}

		private EnumBuilder FindMatchingEnumBuilder(AnonymousEnumBuilder anonEnumBuilder)
		{
			EnumBuilder enumBuilder = null;

			foreach (var realEnumBuilder in _generatedTypes.Values.IsType<EnumBuilder>())
			{
				if (anonEnumBuilder.Fields.Count != realEnumBuilder.Fields.Count)
					continue;

				if (anonEnumBuilder.IsFlags != realEnumBuilder.IsFlags)
					continue;

				var pairs = anonEnumBuilder.Fields.OrderBy(f => f.Name).Zip(realEnumBuilder.Fields.OrderBy(f => f.Name), (a, b) => new Tuple<EnumFieldBuilder, EnumFieldBuilder>(a, b));

				if (!pairs.All(x => x.Item1.Name == x.Item2.Name && x.Item1.NumericValue == x.Item2.NumericValue))
					continue;

				if (enumBuilder != null)
					throw new Exception("Two enums found.");

				enumBuilder = realEnumBuilder;
			}

			return enumBuilder;
		}

		public void WriteEntityFiles(IEnumerable<FileBuilder> fileBuilders)
		{
			foreach (var fileBuilder in fileBuilders)
			{
				string directory = Path.Combine(Path.Combine(Constants.EntitiesProjectRoot, "Generated_"), Path.Combine(fileBuilder.FolderPaths));
				if (!Directory.Exists(directory))
					Directory.CreateDirectory(directory);

				string fullFilePath = Path.Combine(directory, fileBuilder.FileName);

				using (FileStream stream = File.Open(fullFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
				{
					fileBuilder.Write(writer);
				}
			}
		}

		public EnumBuilder ProcessEnumType(OpenApiSchema jsonType, string @namespace, string jsonTypeName, string typeName, string typeDescription)
		{
			string jsonFormat = jsonType.Format;

			bool isFlags = jsonType.Extensions.TryGetValue("x-enum-is-bitmask", out var isFlagsTemp) && isFlagsTemp is OpenApiBoolean isFlagsBoolean && isFlagsBoolean.Value;

			EnumBuilder enumBuilder = new EnumBuilder();
			enumBuilder.Namespace = @namespace;
			enumBuilder.Name = typeName;
			enumBuilder.JsonName = jsonTypeName;
			enumBuilder.Description = typeDescription;
			enumBuilder.UnderlyingType = GetEnumUnderlyingType(jsonFormat);
			enumBuilder.IsFlags = isFlags;

			ProcessEnumFields(jsonType, enumBuilder);

			return enumBuilder;
		}

		private void ProcessEnumFields(OpenApiSchema jsonType, EnumBuilder enumBuilder)
		{
			var jsonEnumValues = (OpenApiArray)jsonType.Extensions["x-enum-values"];

			foreach (OpenApiObject jsonEnumValue in jsonEnumValues)
			{
				var jsonIdentifier = (OpenApiString)jsonEnumValue["identifier"];
				var jsonNumericValue = jsonEnumValue["numericValue"];
				jsonEnumValue.TryGetValue("description", out var jsonMemberDescription);

				var enumFieldBuilder = new EnumFieldBuilder();
				enumFieldBuilder.Name = jsonIdentifier.Value;
				enumFieldBuilder.JsonName = jsonIdentifier.Value;

				if (jsonNumericValue is OpenApiLong longValue)
					enumFieldBuilder.NumericValue = longValue.Value.ToString();
				if (jsonNumericValue is OpenApiInteger integerValue)
					enumFieldBuilder.NumericValue = integerValue.Value.ToString();
				if (jsonNumericValue is OpenApiByte byteValue)
					enumFieldBuilder.NumericValue = byteValue.Value.ToString();

				if (jsonMemberDescription != null)
					enumFieldBuilder.Description = ((OpenApiString)jsonMemberDescription).Value;

				enumBuilder.Fields.Add(enumFieldBuilder);
			}
		}

		public DictionaryBuilder ProcessDictionaryType(OpenApiSchema jsonTypeProperty, OpenApiSchema dictionaryKey, OpenApiSchema dictionaryValue, string @namespace, string jsonTypeName, string typeName, string typeDescription)
		{
			ClassBuilder classBuilder = ProcessClassType(jsonTypeProperty, @namespace, jsonTypeName, typeName, typeDescription);

			DictionaryBuilder dictionaryBuilder = new DictionaryBuilder();
			dictionaryBuilder.Namespace = @namespace;
			dictionaryBuilder.Name = typeName;
			dictionaryBuilder.JsonName = jsonTypeName;
			dictionaryBuilder.Description = typeDescription;

			dictionaryBuilder.KeyType = ProcessPropertyType(dictionaryKey);
			dictionaryBuilder.ItemType = ProcessPropertyType(dictionaryValue);

			foreach (var property in classBuilder.Properties)
				dictionaryBuilder.Properties.Add(property);

			return dictionaryBuilder;
		}

		public ClassBuilder ProcessClassType(OpenApiSchema jsonTypeProperty, string @namespace, string jsonTypeName, string typeName, string typeDescription)
		{
			ClassBuilder classBuilder = new ClassBuilder();
			classBuilder.Namespace = @namespace;
			classBuilder.Name = typeName;
			classBuilder.JsonName = jsonTypeName;
			classBuilder.Description = typeDescription;

			var jsonProperties = jsonTypeProperty.Properties;

			foreach (var jsonProperty in jsonProperties)
			{
				PropertyBuilder propertyBuilder = new PropertyBuilder();
				propertyBuilder.Name = ConvertIdentifierToPascalCase(jsonProperty.Key);
				propertyBuilder.JsonName = jsonProperty.Key;

				propertyBuilder.Type = ProcessPropertyType(jsonProperty.Value);

				if (propertyBuilder.Type.IsValid)
					classBuilder.Properties.Add(propertyBuilder);
			}

			return classBuilder;
		}

		public TypeReference ProcessPropertyType(OpenApiSchema jsonPropertyValue)
		{
			string jsonDollarRef = jsonPropertyValue.Reference?.ReferenceV3;
			if (jsonDollarRef != null)
				return new TypeReference(jsonDollarRef);
			var jsonType = jsonPropertyValue.Type;
			var jsonFormat = jsonPropertyValue.Format;
			var jsonNullable = jsonPropertyValue.Nullable;
			jsonPropertyValue.Extensions.TryGetValue("x-enum-reference", out var enumReferenceTemp);

			if (jsonType == "boolean")
				return jsonNullable ? typeof(bool?) : typeof(bool);

			if (jsonType == "integer")
			{
				if (jsonPropertyValue.Enum != null && jsonPropertyValue.Enum.Count > 0)
				{
					AnonymousEnumBuilder enumBuilder = new AnonymousEnumBuilder();
					enumBuilder.IsFlags = false;
					enumBuilder.UnderlyingType = GetEnumUnderlyingType(jsonFormat);

					ProcessEnumFields(jsonPropertyValue, enumBuilder);

					if (jsonNullable)
						return new NullableEnumBuilder() { EnumBuilder = enumBuilder };

					return enumBuilder;
				}

				if (enumReferenceTemp is OpenApiObject enumReference)
				{
					jsonDollarRef = ((OpenApiString)enumReference["$ref"]).Value;
					return new TypeReference(jsonDollarRef);
				}

				if (jsonFormat == "byte")
					return jsonNullable ? typeof(byte?) : typeof(byte);
				else if (jsonFormat == "sbyte")
					return jsonNullable ? typeof(sbyte?) : typeof(sbyte);
				else if (jsonFormat == "int16")
					return jsonNullable ? typeof(short?) : typeof(short);
				else if (jsonFormat == "uint16")
					return jsonNullable ? typeof(ushort?) : typeof(ushort);
				else if (jsonFormat == "int32")
					return jsonNullable ? typeof(int?) : typeof(int);
				else if (jsonFormat == "uint32")
					return jsonNullable ? typeof(uint?) : typeof(uint);
				else if (jsonFormat == "int64")
					return jsonNullable ? typeof(long?) : typeof(long);
				else if (jsonFormat == "uint64")
					return jsonNullable ? typeof(ulong?) : typeof(ulong);
			}
			else if (jsonType == "number")
			{
				if (jsonFormat == "float")
					return jsonNullable ? typeof(decimal?) : typeof(decimal);  //return jsonNullable ? typeof(float?) : typeof(float);
				else if (jsonFormat == "double")
					return jsonNullable ? typeof(decimal?) : typeof(decimal);  //return jsonNullable ? typeof(double?) : typeof(double);
				else //if (jsonFormat == "decimal")
					return jsonNullable ? typeof(decimal?) : typeof(decimal);
			}
			else if (jsonType == "string")
			{
				if (jsonFormat == "date-time")
					return jsonNullable ? typeof(DateTime?) : typeof(DateTime);
				else if (jsonFormat == "byte")
					return jsonNullable ? typeof(byte?) : typeof(byte);
				else
					return typeof(string);
			}
			else if (jsonType == "object")
			{
				if (jsonPropertyValue.Extensions.TryGetValue("x-dictionary-key", out var dictionaryKeyTemp))
				{
					var dictionaryKey = TranslateDictionaryKeyExtensionToSchema(dictionaryKeyTemp);
					var dictionaryValue = jsonPropertyValue.AdditionalProperties;

					return new DictionaryBuilder()
					{
						KeyType = ProcessPropertyType(dictionaryKey),
						ItemType = ProcessPropertyType(dictionaryValue)
					};
				}

				var allOf = jsonPropertyValue.AllOf;
				if (allOf != null && allOf.Count > 0)
					return ProcessPropertyType(allOf[0]);

				return default;
			}
			else if (jsonType == "array")
			{
				var arrayElementType = ProcessPropertyType(jsonPropertyValue.Items);

				return new ArrayBuilder()
				{
					Name = arrayElementType.Name + "[]",
					ElementType = arrayElementType
				};
			}
			else
			{
			}

			return default;
		}

		private OpenApiSchema TranslateDictionaryKeyExtensionToSchema(IOpenApiExtension extension)
		{
			// The value of "x-dictionary-key" is a type reference, which will have a "type" property
			// and possibly properties like "format" or "enum" depending on the type.

			// This method serializes the object from the Extensions property and deserializes it as an
			// OpenApiSchema object.

			using (StringWriter stringWriter = new StringWriter())
			{
				extension.Write(new OpenApiJsonWriter(stringWriter), OpenApiSpecVersion.OpenApi3_0);

				using (StringReader stringReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
				{
					return new OpenApiStringReader().ReadFragment<OpenApiSchema>(stringWriter.GetStringBuilder().ToString(), OpenApiSpecVersion.OpenApi3_0, out var diagnostics);
				}
			}
		}

		public void GenerateClient(bool writeFiles)
		{
			List<MethodBuilder> methodBuilders = new List<MethodBuilder>();

			foreach (var jsonPathProperty in _openapi.Paths)
			{
				string path = jsonPathProperty.Key;
				string summary = jsonPathProperty.Value.Summary;
				string description = jsonPathProperty.Value.Description;

				jsonPathProperty.Value.Operations.TryGetValue(OperationType.Get, out var get);
				jsonPathProperty.Value.Operations.TryGetValue(OperationType.Post, out var post);

				MethodBuilder methodBuilder = null;

				if (get != null)
				{
					string operationId = get.OperationId;
					var (area, name) = ParseOperationIdToMethodName(operationId);

					bool isStatsEndpoint = _statsOperations.Contains(operationId);

					methodBuilder = GenerateMethod(_openapi, get, false, isStatsEndpoint, path, area, name, description);
				}
				else if (post != null)
				{
					string operationId = post.OperationId;
					var (area, name) = ParseOperationIdToMethodName(operationId);

					bool isStatsEndpoint = _statsOperations.Contains(operationId);

					methodBuilder = GenerateMethod(_openapi, post, true, isStatsEndpoint, path, area, name, description);
				}

				if (methodBuilder != null)
					methodBuilders.Add(methodBuilder);
			}

			var @namespace = Constants.RootNamespace + ".Api";

			var interfaceBuilders = (
				from mb in methodBuilders
				group mb by mb.Area into areas
				select new InterfaceBuilder()
				{
					Namespace = @namespace,
					Name = $"I{areas.Key}Client",
					Area = areas.Key,
					Methods = areas.ToList()
				}).ToList();

			var fileBuilders = (
				from interfaceBuilder in interfaceBuilders
				select new FileBuilder()
				{
					FolderPaths = Array.Empty<string>(),
					FileName = $"I{interfaceBuilder.Area}Client.cs",
					Builder = interfaceBuilder
				}).ToList();

			if (writeFiles)
				WriteClientFiles(fileBuilders);
		}

		private void WriteClientFiles(IEnumerable<FileBuilder> fileBuilders)
		{
			foreach (var fileBuilder in fileBuilders)
			{
				string directory = Path.Combine(Path.Combine(Constants.ClientProjectRoot, "Api", "Generated_"), Path.Combine(fileBuilder.FolderPaths));
				if (!Directory.Exists(directory))
					Directory.CreateDirectory(directory);

				string fullFilePath = Path.Combine(directory, fileBuilder.FileName);

				using (FileStream stream = File.Open(fullFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
				{
					fileBuilder.Write(writer);
				}
			}
		}

		private (string, string) ParseOperationIdToMethodName(string summary)
		{
			int dotIndex = summary.IndexOf('.');
			if (dotIndex < 0)
				throw new ArgumentException("", nameof(summary));

			string area = summary.Substring(0, dotIndex);
			string name = summary.Substring(dotIndex + 1);

			if (area == "")
				area = "App";

			return (area, name);
		}

		public MethodBuilder GenerateMethod(OpenApiDocument document, OpenApiOperation method, bool isPost, bool isStatsEndpoint, string path, string area, string name, string description)
		{
			if (!path.StartsWith("/"))
				throw new ArgumentException("Path must start and end with a slash.", nameof(path));

			bool includeTrailingSlash = path.EndsWith("/");

			TypeReference returnType = GrokReturnType(document, method.Responses["200"]);

			List<ParameterBuilder> parameterBuilders = (
				from jsonParameter in method.Parameters
				select new ParameterBuilder()
				{
					JsonName = jsonParameter.Name,
					Name = jsonParameter.Name,
					Location = (BuilderParameterLocation?)jsonParameter.In ?? throw new Exception("Null argument location."),
					Description = jsonParameter.Description,
					Type = ProcessPropertyType(jsonParameter.Schema),
				}).ToList();

			foreach (var parameterBuilder in parameterBuilders)
			{
				if (parameterBuilder.Type.IsJsonPath)
				{
					if (!_generatedTypes.TryGetValue(parameterBuilder.Type.JsonPath, out TypeBuilder newTypeBuilder))
						throw new Exception($"Method '{name}' has parameter '{parameterBuilder.Name}' with reference to unknown type '{parameterBuilder.Type.JsonPath}'.");

					parameterBuilder.Type = newTypeBuilder;
				}
			}

			// The finalParameterBuilders list orders the path parameters as they're found in the path,
			// which is not the order they're specified in the JSON, and then appends the remaining
			// parameters in the order they appear in the JSON.
			List<ParameterBuilder> finalParameterBuilders = new List<ParameterBuilder>();

			List<PathSegment> pathSegments = (
				from ps in path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)
				select (PathSegment)new ConstantPathSegment() { Value = ps }
				).ToList();

			for (int index = 0; index < pathSegments.Count; ++index)
			{
				PathSegment pathSegment = pathSegments[index];

				string value = ((ConstantPathSegment)pathSegment).Value;

				if (value.StartsWith("{") && value.EndsWith("}"))
				{
					string jsonParameterName = value.Substring(1, value.Length - 2);
					string parameterName = jsonParameterName;

					ParameterBuilder parameterBuilder = (
						from p in parameterBuilders
						where p.Name == parameterName
						where p.Location == BuilderParameterLocation.Path
						select p
						).FirstOrDefault();

					if (parameterBuilder == null)
						throw new Exception("No parameter found for path segment.");

					pathSegments[index] = new ParameterPathSegment()
					{
						Parameter = parameterBuilder
					};

					finalParameterBuilders.Add(parameterBuilder);
				}
			}

			// According to a couple issue discussions, "path" parameters that are not in braces in the
			// path are actually "query" parameters.  Since "cookie" and "header" aren't used, we can
			// determine "query" parameters by exclusion.  Trying to validate that every parameter
			// identified as path is in the path is not possible.

			List<ParameterBuilder> queryItems = (
				from p in parameterBuilders
				where !pathSegments.OfType<ParameterPathSegment>().Any(ps => ps.Parameter.Name == p.Name)
				select p
				).ToList();

			foreach (var qi in queryItems)
				finalParameterBuilders.Add(qi);

			if (finalParameterBuilders.Any())
			{
				ParameterBuilder lastParameterBuilder = finalParameterBuilders.Last();
				var typeReference = lastParameterBuilder.Type;
				if (typeReference.IsTypeBuilder)
				{
					if (typeReference.TypeBuilder is ArrayBuilder arrayBuilder && arrayBuilder.ElementType.JsonPath == TypeReference.ComponentsSchemasRootPath + "Destiny.DestinyComponentType")
						lastParameterBuilder.IsParams = true;
				}
			}

			if (isPost)
			{
				if (method.RequestBody != null)
				{
					TypeReference typeReference = ProcessPropertyType(method.RequestBody.Content["application/json"].Schema);

					string requestParameterName = "request";
					if (typeReference.IsJsonPath && _generatedTypes.TryGetValue(typeReference.JsonPath, out TypeBuilder tb) && tb is ClassBuilder classBuilder)
					{
						requestParameterName = ConvertIdentifierToCamelCase(classBuilder.Name);
					}

					finalParameterBuilders.Insert(0, new ParameterBuilder()
					{
						Name = requestParameterName,
						JsonName = requestParameterName,
						Location = BuilderParameterLocation.Body,
						Type = typeReference
					});
				}
			}

			return new MethodBuilder()
			{
				Name = name,
				JsonName = name,
				Description = description,
				Area = area,
				IsPost = isPost,
				IsStatsEndpoint = isStatsEndpoint,
				ReturnType = returnType,
				Parameters = finalParameterBuilders,
				PathSegments = pathSegments,
				IncludeTrailingSlash = includeTrailingSlash,
				QueryItems = queryItems
			};
		}

		private TypeReference GrokReturnType(OpenApiDocument document, OpenApiResponse responseRef)
		{
			const string prefixIReadOnlyCollectionOf = "IReadOnlyCollectionOf";

			string responseName = responseRef.Reference.ReferenceV3.Substring("#/components/responses/".Length);

			if (responseName.StartsWith(prefixIReadOnlyCollectionOf))
			{
				string typeName = responseName.Substring(prefixIReadOnlyCollectionOf.Length);

				string @namespace = _generatedTypes.Values.Where(v => v.Name == typeName).FirstOrDefault()?.Namespace ?? "";
				string qualifiedTypeName = @namespace + "." + typeName;

				document.Components.Schemas.TryGetValue(qualifiedTypeName, out var schemaType);

				return new ArrayBuilder()
				{
					ElementType = schemaType.Reference.ReferenceV3
				};
			}

			OpenApiResponse response = document.Components.Responses[responseName];

			var responseType = response.Content["application/json"].Schema.Properties["Response"];

			TypeReference result = ProcessPropertyType(responseType);

			if (result.IsJsonPath)
				result = _generatedTypes[result.JsonPath];

			return result;
		}
	}
}

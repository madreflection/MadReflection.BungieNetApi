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
	public static class EntitiesGenerator
	{
		private static readonly List<string> _flags = new List<string>()
		{
			"Applications.ApplicationScopes",
			"Destiny.Definitions.DestinyTalentNodeStepDamageTypes",
			"Destiny.Definitions.DestinyTalentNodeStepGuardianAttributes",
			"Destiny.Definitions.DestinyTalentNodeStepImpactEffects",
			"Destiny.Definitions.DestinyTalentNodeStepLightAbilities",
			"Destiny.Definitions.DestinyTalentNodeStepWeaponPerformances",
			"Destiny.DestinyGameVersions",
			"Destiny.DestinyVendorItemState",
			"Destiny.EquipFailureReason",
			"Destiny.ItemState",
			"Destiny.SocketPlugSources",
			"Destiny.TransferStatuses",
			"Destiny.VendorItemStatus",
			"Forum.ForumFlagsEnum",
			"Forum.ForumPostCategoryEnums",
			"Forum.ForumTopicsCategoryFiltersEnum",
			"GroupsV2.Capabilities",
			"Ignores.IgnoreStatus",
			"BungieMembershipType"
		};

		public static void GenerateEntities(OpenApiDocument openapi, bool writeFiles)
		{
			List<FileBuilder> fileBuilders = new List<FileBuilder>();

			foreach (var jsonTypeProperty in openapi.Components.Schemas)
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

					var jsonEnum = jsonValueObject.Enum;
					var jsonEnumValues = jsonValueObject.Extensions["x-enum-values"];

					if (jsonEnum != null && jsonEnumValues != null)
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
				{
					Program.GeneratedTypes.Add(TypeReference.ComponentsSchemasRootPath + jsonTypeProperty.Key, typeBuilder);

					fileBuilders.Add(new FileBuilder()
					{
						FolderPaths = SplitNamespace(jsonTypeProperty.Key).Split('.'),
						FileName = jsonTypeName + ".cs",
						Builder = typeBuilder
					});
				}
			}

			ResolveJsonPathTypeReferences(Program.GeneratedTypes);
			ResolveDefinitionBaseClass(Program.GeneratedTypes);

			if (writeFiles)
				WriteFiles(fileBuilders);
		}

		private static void ResolveJsonPathTypeReferences(Dictionary<string, TypeBuilder> typeBuilders)
		{
			foreach (var (typeName, typeBuilder) in typeBuilders)
			{
				if (typeBuilder is ClassBuilder classBuilder)
				{
					foreach (var propertyBuilder in classBuilder.Properties)
					{
						if (propertyBuilder.Type.IsJsonPath)
						{
							if (!Program.GeneratedTypes.TryGetValue(propertyBuilder.Type.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{propertyBuilder.Name}' with reference to unknown type '{propertyBuilder.Type.JsonPath}'.");

							propertyBuilder.Type = newTypeBuilder;
						}
						else if (propertyBuilder.Type.IsTypeBuilder)
						{
							if (propertyBuilder.Type.TypeBuilder is NullableEnumBuilder nullableEnumBuilder)
							{
								if (nullableEnumBuilder.EnumBuilder is AnonymousEnumBuilder anonEnumBuilder)
								{
									propertyBuilder.Type = new NullableEnumBuilder() { EnumBuilder = FindMatchingEnumBuilder(anonEnumBuilder) };
								}
								else
								{
									// OOPS!
								}
							}
							else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
							{
								propertyBuilder.Type = FindMatchingEnumBuilder(anonEnumBuilder);
							}
						}
					}

					if (typeBuilder is DictionaryBuilder dictionaryBuilder)
					{
						if (dictionaryBuilder.KeyType.IsJsonPath)
						{
							if (!Program.GeneratedTypes.TryGetValue(dictionaryBuilder.KeyType.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{dictionaryBuilder.KeyType.Name}' with reference to unknown type '{dictionaryBuilder.KeyType.JsonPath}'.");

							dictionaryBuilder.KeyType = newTypeBuilder;
						}
						//else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
						//{
						//}

						if (dictionaryBuilder.ItemType.IsJsonPath)
						{
							if (!Program.GeneratedTypes.TryGetValue(dictionaryBuilder.ItemType.JsonPath, out TypeBuilder newTypeBuilder))
								throw new Exception($"Type '{typeBuilder.Name}' has property '{dictionaryBuilder.ItemType.Name}' with reference to unknown type '{dictionaryBuilder.ItemType.JsonPath}'.");

							dictionaryBuilder.ItemType = newTypeBuilder;
						}
						//else if (typeBuilder is AnonymousEnumBuilder anonEnumBuilder)
						//{
						//}
					}
				}
				else if (typeBuilder is ArrayBuilder arrayBuilder)
				{
					if (arrayBuilder.ElementType.IsJsonPath)
					{
						if (!Program.GeneratedTypes.TryGetValue(arrayBuilder.ElementType.JsonPath, out TypeBuilder newTypeBuilder))
							throw new Exception($"Type '{typeBuilder.Name}' has property '{arrayBuilder.ElementType.Name}' with reference to unknown type '{arrayBuilder.ElementType.JsonPath}'.");

						arrayBuilder.ElementType = newTypeBuilder;
					}
				}
			}
		}

		private static void ResolveDefinitionBaseClass(Dictionary<string, TypeBuilder> typeBuilders)
		{
			foreach (var (typeName, typeBuilder) in typeBuilders)
			{
				if (typeName == "#/components/schemas/Destiny.Definitions.DestinyDefinition")
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
						classBuilder.BaseType = "#/components/schemas/Destiny.Definitions.DestinyDefinition";
					}

				}
			}
		}

		private static EnumBuilder FindMatchingEnumBuilder(AnonymousEnumBuilder anonEnumBuilder)
		{
			EnumBuilder enumBuilder = null;

			foreach (var realEnumBuilder in Program.GeneratedTypes.Values.IsType<EnumBuilder>())
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

		private static TypeBuilder LookUpTypeBuilder(string jsonPath)
		{
			if (jsonPath == null)
				throw new ArgumentNullException(nameof(jsonPath));

			if (!Program.GeneratedTypes.TryGetValue(jsonPath, out TypeBuilder typeBuilder))
				throw new ArgumentException($"JSON type reference not found: '{jsonPath}'.", nameof(jsonPath));

			return typeBuilder;
		}

		public static void WriteFiles(IEnumerable<FileBuilder> fileBuilders)
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

		public static EnumBuilder ProcessEnumType(OpenApiSchema jsonType, string @namespace, string jsonTypeName, string typeName, string typeDescription)
		{
			string jsonFormat = jsonType.Format;

			EnumBuilder enumBuilder = new EnumBuilder();
			enumBuilder.Namespace = @namespace;
			enumBuilder.Name = typeName;
			enumBuilder.JsonName = jsonTypeName;
			enumBuilder.Description = typeDescription;
			enumBuilder.UnderlyingType = GetEnumUnderlyingType(jsonFormat);
			enumBuilder.IsFlags = _flags.Contains($"{@namespace}.{typeName}");

			ProcessEnumFields(jsonType, enumBuilder);

			return enumBuilder;
		}

		private static void ProcessEnumFields(OpenApiSchema jsonType, EnumBuilder enumBuilder)
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

		public static DictionaryBuilder ProcessDictionaryType(OpenApiSchema jsonTypeProperty, OpenApiSchema dictionaryKey, OpenApiSchema dictionaryValue, string @namespace, string jsonTypeName, string typeName, string typeDescription)
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

		public static ClassBuilder ProcessClassType(OpenApiSchema jsonTypeProperty, string @namespace, string jsonTypeName, string typeName, string typeDescription)
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
				propertyBuilder.Name = DotNetifyIdentifier(jsonProperty.Key);
				propertyBuilder.JsonName = jsonProperty.Key;

				propertyBuilder.Type = ProcessPropertyType(jsonProperty.Value);

				if (propertyBuilder.Type.IsValid)
					classBuilder.Properties.Add(propertyBuilder);
			}

			return classBuilder;
		}

		public static TypeReference ProcessPropertyType(OpenApiSchema jsonPropertyValue)
		{
			string jsonDollarRef = jsonPropertyValue.Reference?.ReferenceV3;
			if (jsonDollarRef != null)
				return new TypeReference(jsonDollarRef);
			var jsonType = jsonPropertyValue.Type;
			var jsonFormat = jsonPropertyValue.Format;
			var jsonNullable = jsonPropertyValue.Nullable;

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

		private static OpenApiSchema TranslateDictionaryKeyExtensionToSchema(IOpenApiExtension extension)
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
	}
}

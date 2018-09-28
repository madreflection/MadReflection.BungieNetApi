using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Linq;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public static class ClientGenerator
	{
		public static void GenerateClient(OpenApiDocument openapi, bool writeFiles)
		{
			List<MethodBuilder> methodBuilders = new List<MethodBuilder>();

			foreach (var jsonPathProperty in openapi.Paths)
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

					methodBuilder = GenerateMethod(openapi, get, false, path, area, name, description);
				}
				else if (post != null)
				{
					string operationId = post.OperationId;
					var (area, name) = ParseOperationIdToMethodName(operationId);

					methodBuilder = GenerateMethod(openapi, post, true, path, area, name, description);
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
				WriteFiles(fileBuilders);
		}

		private static void WriteFiles(IEnumerable<FileBuilder> fileBuilders)
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

		private static (string, string) ParseOperationIdToMethodName(string summary)
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

		public static MethodBuilder GenerateMethod(OpenApiDocument document, OpenApiOperation method, bool isPost, string path, string area, string name, string description)
		{
			if (!path.StartsWith("/") || !path.EndsWith("/"))
				throw new ArgumentException("Path must start and end with a slash.", nameof(path));

			TypeReference returnType = GrokReturnType(document, method.Responses["200"]);

			List<ParameterBuilder> parameterBuilders = (
				from jsonParameter in method.Parameters
				select new ParameterBuilder()
				{
					JsonName = jsonParameter.Name,
					Name = jsonParameter.Name,
					Location = (BuilderParameterLocation?)jsonParameter.In ?? throw new Exception("Null argument location."),
					Description = jsonParameter.Description,
					Type = EntitiesGenerator.ProcessPropertyType(jsonParameter.Schema),
				}).ToList();

			foreach (var parameterBuilder in parameterBuilders)
			{
				if (parameterBuilder.Type.IsJsonPath)
				{
					if (!Program.GeneratedTypes.TryGetValue(parameterBuilder.Type.JsonPath, out TypeBuilder newTypeBuilder))
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

			if (isPost)
			{
				if (method.RequestBody != null)
				{
					TypeReference typeReference = EntitiesGenerator.ProcessPropertyType(method.RequestBody.Content["application/json"].Schema);

					string requestParameterName = "request";
					if (typeReference.IsJsonPath && Program.GeneratedTypes.TryGetValue(typeReference.JsonPath, out TypeBuilder tb) && tb is ClassBuilder classBuilder)
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
				ReturnType = returnType,
				Parameters = finalParameterBuilders,
				PathSegments = pathSegments,
				QueryItems = queryItems
			};
		}

		private static TypeReference GrokReturnType(OpenApiDocument document, OpenApiResponse responseRef)
		{
			string responseName = responseRef.Reference.ReferenceV3.Substring("#/components/responses/".Length);

			OpenApiResponse response = document.Components.Responses[responseName];

			var responseType = response.Content["application/json"].Schema.Properties["Response"];

			TypeReference result = EntitiesGenerator.ProcessPropertyType(responseType);

			if (result.IsJsonPath)
				result = Program.GeneratedTypes[result.JsonPath];

			return result;
		}
	}
}

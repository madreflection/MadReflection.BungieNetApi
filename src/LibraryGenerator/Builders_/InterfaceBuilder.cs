using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.OpenApi.Models;

namespace LibraryGenerator
{
	public class InterfaceBuilder : TypeBuilder
	{
		public string Area { get; set; }

		public List<MethodBuilder> Methods { get; set; } = new List<MethodBuilder>();


		public override void Write(TextWriter writer)
		{
			writer.WriteLine("using System;");
			writer.WriteLine("using System.Threading.Tasks;");
			writer.WriteLine("using Newtonsoft.Json;");
			writer.WriteLine();

			writer.WriteLine("namespace BungieNet.Api");
			writer.WriteLine("{");

			writer.WriteLine($"\tpublic interface {Name}");
			writer.WriteLine("\t{");

			int lastIndex = Methods.Count - 1;

			for (int index = 0; index <= lastIndex; index++)
			{
				MethodBuilder methodBuilder = Methods[index];

				writer.Write("\t\t");
				WriteSignature(writer, methodBuilder);
				writer.WriteLine(";");

				writer.Write("\t\t");
				WriteAsyncSignature(writer, methodBuilder);
				writer.WriteLine(";");

				if (index < lastIndex)
					writer.WriteLine();
			}

			writer.WriteLine("\t}");

			writer.WriteLine();

			writer.WriteLine("\tpartial interface IBungieClient");
			writer.WriteLine("\t{");
			writer.WriteLine($"\t\t{Name} {Area} {{ get; }}");
			writer.WriteLine("\t}");

			writer.WriteLine();

			writer.WriteLine($"\tpartial class BungieClient : {Name}");
			writer.WriteLine("\t{");
			writer.WriteLine($"\t\tpublic {Name} {Area} => this;");
			writer.WriteLine();
			writer.WriteLine();

			for (int methodIndex = 0; methodIndex <= lastIndex; ++methodIndex)
			{
				MethodBuilder methodBuilder = Methods[methodIndex];

				writer.Write($"\t\t{methodBuilder.ReturnType.QualifiedName} {Name}.{methodBuilder.Name}(");
				WriteParameters(writer, methodBuilder.Parameters, typeDeclaration: true);
				writer.Write($") => {Area}.{methodBuilder.Name}Async(");
				WriteParameters(writer, methodBuilder.Parameters, typeDeclaration: false);
				writer.WriteLine(").GetAwaiter().GetResult();");


				writer.Write($"\t\tTask<{methodBuilder.ReturnType.QualifiedName}> {Name}.{methodBuilder.Name}Async(");
				WriteParameters(writer, methodBuilder.Parameters, typeDeclaration: true);
				writer.WriteLine($")");

				writer.WriteLine("\t\t{");

				WriteParameterNullGuards(writer, methodBuilder);

				writer.Write("\t\t\tstring[] pathSegments = new string[] { ");
				int lastPathSegmentIndex = methodBuilder.PathSegments.Count - 1;
				for (int pathSegmentIndex = 0; pathSegmentIndex <= lastPathSegmentIndex; ++pathSegmentIndex)
				{
					PathSegment pathSegment = methodBuilder.PathSegments[pathSegmentIndex];

					writer.Write(pathSegment.StringExpression);

					if (pathSegmentIndex < lastPathSegmentIndex)
						writer.Write(", ");
				}
				writer.WriteLine(" };");

				string queryItemsExpression = "null";
				if (methodBuilder.QueryItems.Any())
				{
					writer.WriteLine("\t\t\tSystem.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()");
					writer.WriteLine("\t\t\t{");

					int lastQueryItemIndex = methodBuilder.QueryItems.Count - 1;

					for (int queryItemIndex = 0; queryItemIndex <= lastQueryItemIndex; ++queryItemIndex)
					{
						var queryItem = methodBuilder.QueryItems[queryItemIndex];

						writer.Write($"\t\t\t\tnew QueryStringItem(\"{queryItem.Name}\", {queryItem.StringExpression})");

						if (queryItemIndex < lastQueryItemIndex)
							writer.Write(",");

						writer.WriteLine();
					}

					writer.WriteLine("\t\t\t};");

					queryItemsExpression = "queryItems";
				}

				writer.WriteLine($"\t\t\tUri uri = GetEndpointUri(pathSegments, {queryItemsExpression});");

				writer.Write("\t\t\treturn ");
				string getOrPost = methodBuilder.IsPost ? "Post" : "Get";
				if (methodBuilder.ReturnType.IsArray)
				{
					var elementType = ((ArrayBuilder)methodBuilder.ReturnType.TypeBuilder).ElementType;
					writer.Write($"{getOrPost}EntityArrayAsync");
					writer.Write($"<{elementType.QualifiedName}>");
				}
				else
				{
					writer.Write($"{getOrPost}EntityAsync");
					writer.Write($"<{methodBuilder.ReturnType.QualifiedName}>");
				}
				writer.WriteLine($"(uri);");

				writer.WriteLine("\t\t}");

				if (methodIndex < lastIndex)
					writer.WriteLine();
			}

			writer.WriteLine("\t}");

			writer.WriteLine("}");
		}

		private static void WriteParameterNullGuards(TextWriter writer, MethodBuilder methodBuilder)
		{
			foreach (var parameterBuilder in methodBuilder.Parameters.Where(p => p.Location == ParameterLocation.Path))
			{
				TypeReference parameterType = parameterBuilder.Type;

				if (parameterType.Type != null)
				{
					if (!parameterBuilder.Type.Type.IsValueType)
						WriteParameterNullGuard(writer, parameterBuilder.Name);
				}
				else if (parameterType.TypeBuilder != null)
				{
					if (parameterType.TypeBuilder is ClassBuilder classBuilder)
						WriteParameterNullGuard(writer, parameterBuilder.Name);
				}
			}
		}

		private static void WriteParameterNullGuard(TextWriter writer, string parameterName)
		{
			writer.WriteLine($"\t\t\tif ({parameterName} is null)");
			writer.WriteLine($"\t\t\t\tthrow new ArgumentNullException(nameof({parameterName}));");
		}

		private void WriteSignature(TextWriter writer, MethodBuilder methodBuilder)
		{
			writer.Write($"{methodBuilder.ReturnType.QualifiedName} {methodBuilder.Name}(");
			WriteParameters(writer, methodBuilder.Parameters, true);
			writer.Write(")");
		}

		private void WriteAsyncSignature(TextWriter writer, MethodBuilder methodBuilder)
		{
			writer.Write($"Task<{methodBuilder.ReturnType.QualifiedName}> {methodBuilder.Name}Async(");
			WriteParameters(writer, methodBuilder.Parameters, true);
			writer.Write(")");
		}

		private void WriteParameters(TextWriter writer, List<ParameterBuilder> parameters, bool typeDeclaration)
		{
			int lastParameterIndex = parameters.Count - 1;

			for (int parameterIndex = 0; parameterIndex <= lastParameterIndex; ++parameterIndex)
			{
				ParameterBuilder parameterBuilder = parameters[parameterIndex];

				if (typeDeclaration)
				{
					writer.Write(parameterBuilder.Type.QualifiedName);
					writer.Write(" ");
				}
				writer.Write(parameterBuilder.Name);

				if (parameterIndex < lastParameterIndex)
					writer.Write(", ");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public class ClassBuilder : TypeBuilder
	{
		public List<PropertyBuilder> Properties { get; } = new List<PropertyBuilder>();


		public override void Write(TextWriter writer)
		{
			writer.WriteLine("using System;");
			writer.WriteLine("using Newtonsoft.Json;");
			writer.WriteLine();

			writer.WriteLine($"namespace {JoinName(Constants.RootNamespace, Namespace)}");
			writer.WriteLine("{");

			if (!string.IsNullOrEmpty(Description))
			{
				writer.WriteLine("\t/// <summary>");
				foreach (var line in Description.Split(new string[] { "\r\n" }, StringSplitOptions.None))
					writer.WriteLine($"\t/// {EscapeHtmlString(line)}");
				writer.WriteLine("\t/// </summary>");
			}

			writer.WriteLine($"\tpublic partial class {Name}");
			writer.WriteLine("\t{");

			WriteProperties(writer);

			writer.WriteLine("\t}");

			writer.WriteLine("}");
		}

		protected void WriteProperties(TextWriter writer)
		{
			int lastPropertyIndex = Properties.Count - 1;
			for (int index = 0; index <= lastPropertyIndex; index++)
			{
				PropertyBuilder property = Properties[index];
				string typeName = property.Type.QualifiedName;

				if (!string.IsNullOrEmpty(property.Description))
				{
					writer.WriteLine("\t\t/// <summary>");
					foreach (var line in property.Description.Split(new string[] { "\r\n" }, StringSplitOptions.None))
						writer.WriteLine($"\t\t/// {EscapeHtmlString(line)}");
					writer.WriteLine("\t\t/// </summary>");
				}

				writer.WriteLine($"\t\t[JsonProperty(\"{property.JsonName}\")]");
				writer.WriteLine($"\t\tpublic {typeName} {property.Name} {{ get; set; }}");

				if (index < lastPropertyIndex)
					writer.WriteLine();
			}
		}
	}
}

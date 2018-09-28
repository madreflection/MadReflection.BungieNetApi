using System;
using System.Collections.Generic;
using System.IO;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public class EnumBuilder : TypeBuilder
	{
		public List<EnumFieldBuilder> Fields { get; } = new List<EnumFieldBuilder>();


		public bool IsFlags { get; set; }

		public Type UnderlyingType { get; set; }


		public override void Write(TextWriter writer)
		{
			writer.WriteLine("using System;");
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

			if (IsFlags)
				writer.WriteLine("\t[Flags]");

			writer.Write($"\tpublic enum {Name}");
			if (UnderlyingType != typeof(int))
				writer.Write($" : {GetEnumUnderlyingTypeKeyword(UnderlyingType)}");
			writer.WriteLine();

			writer.WriteLine("\t{");

			int lastFieldIndex = Fields.Count - 1;
			for (int index = 0; index <= lastFieldIndex; index++)
			{
				EnumFieldBuilder field = Fields[index];

				if (field.Description != null)
				{
					if (field.Description.StartsWith("Deprecated"))
					{
						writer.WriteLine($"\t\t[Obsolete(\"{EscapeCSharpString(field.Description)}\", true)]");
					}
					else
					{
						writer.WriteLine("\t\t/// <summary>");
						foreach (var line in field.Description.Split(new string[] { "\r\n" }, StringSplitOptions.None))
							writer.WriteLine($"\t\t/// {EscapeHtmlString(line)}");
						writer.WriteLine("\t\t/// </summary>");
					}
				}

				writer.Write($"\t\t{field.Name} = ");

				object value = GetEnumValue(UnderlyingType, field.NumericValue);
				if (IsFlags)
					writer.Write(FormatHex(value));
				else
					writer.Write(value.ToString());

				if (index < lastFieldIndex)
					writer.WriteLine(",");
				writer.WriteLine();
			}

			writer.WriteLine("\t}");

			writer.WriteLine("}");
		}
	}
}

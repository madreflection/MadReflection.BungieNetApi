using System.IO;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public class DictionaryBuilder : ClassBuilder
	{
		public TypeReference KeyType { get; set; }

		public TypeReference ItemType { get; set; }


		public override void Write(TextWriter writer)
		{
			writer.WriteLine("using System;");
			writer.WriteLine("using System.Collections.Generic;");
			writer.WriteLine("using Newtonsoft.Json;");
			writer.WriteLine();

			writer.WriteLine($"namespace {JoinName(Constants.RootNamespace, Namespace)}");
			writer.WriteLine("{");

			writer.WriteLine($"\tpublic class {Name} : Dictionary<{KeyType.QualifiedName}, {ItemType.QualifiedName}>");
			writer.WriteLine("\t{");

			WriteProperties(writer);

			writer.WriteLine("\t}");

			writer.WriteLine("}");
		}
	}
}

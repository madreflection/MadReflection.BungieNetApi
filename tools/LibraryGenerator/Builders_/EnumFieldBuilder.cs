using System;

namespace LibraryGenerator
{
	public class EnumFieldBuilder : Builder
	{
		public Type Type { get; set; }

		public string NumericValue { get; set; }

		public object Value { get; set; }
	}
}

namespace LibraryGenerator
{
	internal struct EnumFieldTypeMetadata
	{
		public readonly string Keyword;
		public readonly string LowerFormat;
		public readonly string UpperFormat;


		public EnumFieldTypeMetadata(string keyword, string upperFormat, string lowerFormat)
		{
			Keyword = keyword;
			UpperFormat = upperFormat;
			LowerFormat = lowerFormat;
		}
	}
}

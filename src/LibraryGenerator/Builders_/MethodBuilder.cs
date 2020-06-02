using System.Collections.Generic;
using System.IO;

namespace LibraryGenerator
{
	public class MethodBuilder : Builder
	{
		public string Area { get; set; }

		public bool IsPost { get; set; }

		public bool IsStatsEndpoint { get; set; }

		public TypeReference ReturnType { get; set; }

		public List<ParameterBuilder> Parameters { get; set; } = new List<ParameterBuilder>();

		public List<PathSegment> PathSegments { get; set; } = new List<PathSegment>();

		public bool IncludeTrailingSlash { get; set; }

		public List<ParameterBuilder> QueryItems { get; set; } = new List<ParameterBuilder>();

		public override void Write(TextWriter writer)
		{
			base.Write(writer);
		}
	}
}

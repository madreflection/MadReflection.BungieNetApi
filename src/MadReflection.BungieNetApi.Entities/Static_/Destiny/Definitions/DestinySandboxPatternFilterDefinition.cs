using System.Collections.Generic;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinySandboxPatternFilterDefinition
	{
		[JsonProperty("artArrangementRegionHash")]
		public uint ArtArrangementRegionHash { get; set; }

		[JsonProperty("artArrangementRegionIndex")]
		public int ArtArrangementRegionIndex { get; set; }

		[JsonProperty("statHash")]
		public uint StatHash { get; set; }

		[JsonProperty("arrangementIndexByStatValue")]
		public Dictionary<int, int> ArrangementIndexByStatValue { get; set; }
	}
}

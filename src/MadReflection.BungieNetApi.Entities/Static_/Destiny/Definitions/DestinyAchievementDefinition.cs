using BungieNet.Destiny.Definitions.Common;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinyAchievementDefinition : DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("acccumulatorThreshold")]
		public int AccumulatorThreshold { get; set; }  // The JSON property is misspelled.

		[JsonProperty("platformIndex")]
		public int PlatformIndex { get; set; }
	}
}

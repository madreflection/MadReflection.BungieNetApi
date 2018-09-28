using BungieNet.Destiny.Definitions.Common;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinyEnemyRaceDefinition : DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
	}
}

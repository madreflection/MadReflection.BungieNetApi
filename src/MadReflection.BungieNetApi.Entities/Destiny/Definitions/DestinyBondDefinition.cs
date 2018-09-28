using BungieNet.Destiny.Definitions.Common;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinyBondDefinition : DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("providedUnlockHash")]
		public uint ProvidedUnlockHash { get; set; }

		[JsonProperty("providedUnlockValueHash")]
		public uint ProvidedUnlockValueHash { get; set; }
	}
}

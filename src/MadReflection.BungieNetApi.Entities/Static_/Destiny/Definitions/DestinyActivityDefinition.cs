using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyActivityDefinition
	{
		[Undocumented]
		[JsonProperty("completionUnlockHash")]
		public uint CompletionUnlockHash { get; set; }

		[Undocumented]
		[JsonProperty("inheritFromFreeRoam")]
		public bool InheritFromFreeRoam { get; set; }

		[Undocumented]
		[JsonProperty("suppressOtherRewards")]
		public bool SuppressOtherRewards { get; set; }
	}
}

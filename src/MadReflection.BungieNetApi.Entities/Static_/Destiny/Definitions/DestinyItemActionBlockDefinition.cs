using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyItemActionBlockDefinition
	{
		[Undocumented]
		[JsonProperty("rewardSheetHash")]
		public uint RewardSheetHash { get; set; }

		[Undocumented]
		[JsonProperty("rewardItemHash")]
		public uint RewardItemHash { get; set; }

		[Undocumented]
		[JsonProperty("rewardSiteHash")]
		public uint RewardSiteHash { get; set; }
	}
}

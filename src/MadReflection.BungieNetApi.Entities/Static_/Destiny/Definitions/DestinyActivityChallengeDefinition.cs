using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyActivityChallengeDefinition
	{
		[Undocumented]
		[JsonProperty("rewardSiteHash")]
		public uint RewardSiteHash { get; set; }

		[Undocumented]
		[JsonProperty("inhibitRewardsUnlockHash")]
		public uint InhibitRewardsUnlockHash { get; set; }
	}
}

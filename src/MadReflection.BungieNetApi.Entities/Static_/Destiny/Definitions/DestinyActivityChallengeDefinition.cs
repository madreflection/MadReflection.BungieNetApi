using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyActivityChallengeDefinition
	{
		[Undocumented]
		[JsonProperty("rewardSiteHash")]
		public long RewardSiteHash { get; set; }

		[Undocumented]
		[JsonProperty("inhibitRewardsUnlockHash")]
		public long InhibitRewardsUnlockHash { get; set; }
	}
}

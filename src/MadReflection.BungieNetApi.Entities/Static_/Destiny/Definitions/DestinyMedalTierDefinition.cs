using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinyMedalTierDefinition : DestinyDefinition
	{
		[Undocumented]
		[JsonProperty("tierName")]
		public string TierName { get; set; }

		[Undocumented]
		[JsonProperty("order")]
		public int Order { get; set; }
	}
}

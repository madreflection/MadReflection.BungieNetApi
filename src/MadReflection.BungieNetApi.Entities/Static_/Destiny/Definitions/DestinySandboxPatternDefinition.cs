using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	public class DestinySandboxPatternDefinition : DestinyDefinition
	{
		[JsonProperty("patternHash")]
		public uint PatternHash { get; set; }

		[JsonProperty("patternGlobalTagIdHash")]
		public uint PatternGlobalTagIdHash { get; set; }

		[JsonProperty("weaponContentGroupHash")]
		public uint WeaponContentGroupHash { get; set; }

		[JsonProperty("weaponTypeHash")]
		public uint WeaponTypeHash { get; set; }

		[JsonProperty("weaponType")]
		public int WeaponType { get; set; }

		[JsonProperty("filters")]
		public DestinySandboxPatternFilterDefinition[] Filters { get; set; }
	}
}

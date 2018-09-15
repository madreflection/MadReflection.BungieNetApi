﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// An item's "Quality" determines its calculated stats. The Level at which the item spawns is combined with its "qualityLevel" along with some additional calculations to determine the value of those stats.
	/// In Destiny 2, most items don't have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
	/// </summary>
	public partial class DestinyItemQualityBlockDefinition
	{
		[JsonProperty("itemLevels")]
		public int[] ItemLevels { get; set; }

		[JsonProperty("qualityLevel")]
		public int QualityLevel { get; set; }

		[JsonProperty("infusionCategoryName")]
		public string InfusionCategoryName { get; set; }

		[JsonProperty("infusionCategoryHash")]
		public uint InfusionCategoryHash { get; set; }

		[JsonProperty("infusionCategoryHashes")]
		public uint[] InfusionCategoryHashes { get; set; }

		[JsonProperty("progressionLevelRequirementHash")]
		public uint ProgressionLevelRequirementHash { get; set; }
	}
}

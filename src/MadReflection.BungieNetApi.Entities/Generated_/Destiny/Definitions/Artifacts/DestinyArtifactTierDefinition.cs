﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Artifacts
{
	public partial class DestinyArtifactTierDefinition
	{
		[JsonProperty("tierHash")]
		public uint TierHash { get; set; }

		[JsonProperty("displayTitle")]
		public string DisplayTitle { get; set; }

		[JsonProperty("progressRequirementMessage")]
		public string ProgressRequirementMessage { get; set; }

		[JsonProperty("items")]
		public Destiny.Definitions.Artifacts.DestinyArtifactTierItemDefinition[] Items { get; set; }

		[JsonProperty("minimumUnlockPointsUsedRequirement")]
		public int MinimumUnlockPointsUsedRequirement { get; set; }
	}
}

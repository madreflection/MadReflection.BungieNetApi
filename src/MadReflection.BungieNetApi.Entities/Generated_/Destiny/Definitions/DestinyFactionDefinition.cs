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
	/// These definitions represent Factions in the game. Factions have ended up unilaterally being related to Vendors that represent them, but that need not necessarily be the case.
	/// A Faction is really just an entity that has a related progression for which a character can gain experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to this relationship), but Dead Orbit could theoretically exist without the Vendor that provides rewards.
	/// </summary>
	public partial class DestinyFactionDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("progressionHash")]
		public uint ProgressionHash { get; set; }

		[JsonProperty("tokenValues")]
		public System.Collections.Generic.Dictionary<uint, uint> TokenValues { get; set; }

		[JsonProperty("rewardItemHash")]
		public uint RewardItemHash { get; set; }

		[JsonProperty("rewardVendorHash")]
		public uint RewardVendorHash { get; set; }

		[JsonProperty("vendors")]
		public Destiny.Definitions.DestinyFactionVendorDefinition[] Vendors { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}
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
	/// Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.
	/// Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points/experience at the same time.
	/// </summary>
	public partial class DestinyProgressionRewardDefinition
	{
		[JsonProperty("progressionMappingHash")]
		public uint ProgressionMappingHash { get; set; }

		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("applyThrottles")]
		public bool ApplyThrottles { get; set; }
	}
}
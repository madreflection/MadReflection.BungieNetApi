﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Milestones
{
	public partial class DestinyPublicMilestoneChallengeActivity
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("challengeObjectiveHashes")]
		public uint[] ChallengeObjectiveHashes { get; set; }

		[JsonProperty("modifierHashes")]
		public uint[] ModifierHashes { get; set; }

		[JsonProperty("loadoutRequirementIndex")]
		public int? LoadoutRequirementIndex { get; set; }
	}
}
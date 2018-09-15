﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny
{
	/// <summary>
	/// Represents the "Live" data that we can obtain about a Character's status with a specific Activity. This will tell you whether the character can participate in the activity, as well as some other basic mutable information. 
	/// Meant to be combined with static DestinyActivityDefinition data for a full picture of the Activity.
	/// </summary>
	public partial class DestinyActivity
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("isNew")]
		public bool IsNew { get; set; }

		[JsonProperty("canLead")]
		public bool CanLead { get; set; }

		[JsonProperty("canJoin")]
		public bool CanJoin { get; set; }

		[JsonProperty("isCompleted")]
		public bool IsCompleted { get; set; }

		[JsonProperty("isVisible")]
		public bool IsVisible { get; set; }

		[JsonProperty("displayLevel")]
		public int? DisplayLevel { get; set; }

		[JsonProperty("recommendedLight")]
		public int? RecommendedLight { get; set; }

		[JsonProperty("difficultyTier")]
		public Destiny.DestinyActivityDifficultyTier DifficultyTier { get; set; }
	}
}

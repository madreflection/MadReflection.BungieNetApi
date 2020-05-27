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

namespace BungieNet.Destiny.Progression
{
	/// <summary>
	/// Mostly for historical purposes, we segregate Faction progressions from other progressions. This is just a DestinyProgression with a shortcut for finding the DestinyFactionDefinition of the faction related to the progression.
	/// </summary>
	public partial class DestinyFactionProgression
	{
		[JsonProperty("factionHash")]
		public uint FactionHash { get; set; }

		[JsonProperty("factionVendorIndex")]
		public int FactionVendorIndex { get; set; }

		[JsonProperty("progressionHash")]
		public uint ProgressionHash { get; set; }

		[JsonProperty("dailyProgress")]
		public int DailyProgress { get; set; }

		[JsonProperty("dailyLimit")]
		public int DailyLimit { get; set; }

		[JsonProperty("weeklyProgress")]
		public int WeeklyProgress { get; set; }

		[JsonProperty("weeklyLimit")]
		public int WeeklyLimit { get; set; }

		[JsonProperty("currentProgress")]
		public int CurrentProgress { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("levelCap")]
		public int LevelCap { get; set; }

		[JsonProperty("stepIndex")]
		public int StepIndex { get; set; }

		[JsonProperty("progressToNextLevel")]
		public int ProgressToNextLevel { get; set; }

		[JsonProperty("nextLevelAt")]
		public int NextLevelAt { get; set; }

		[JsonProperty("currentResetCount")]
		public int? CurrentResetCount { get; set; }

		[JsonProperty("seasonResets")]
		public Destiny.DestinyProgressionResetEntry[] SeasonResets { get; set; }

		[JsonProperty("rewardItemStates")]
		public Destiny.DestinyProgressionRewardItemState[] RewardItemStates { get; set; }
	}
}

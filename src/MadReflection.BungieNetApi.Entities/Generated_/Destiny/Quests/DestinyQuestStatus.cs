﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Quests
{
	/// <summary>
	/// Data regarding the progress of a Quest for a specific character. Quests are composed of multiple steps, each with potentially multiple objectives: this QuestStatus will return Objective data for the *currently active* step in this quest.
	/// </summary>
	public partial class DestinyQuestStatus
	{
		[JsonProperty("questHash")]
		public uint QuestHash { get; set; }

		[JsonProperty("stepHash")]
		public uint StepHash { get; set; }

		[JsonProperty("stepObjectives")]
		public Destiny.Quests.DestinyObjectiveProgress[] StepObjectives { get; set; }

		[JsonProperty("tracked")]
		public bool Tracked { get; set; }

		[JsonProperty("itemInstanceId")]
		public long ItemInstanceId { get; set; }

		[JsonProperty("completed")]
		public bool Completed { get; set; }

		[JsonProperty("redeemed")]
		public bool Redeemed { get; set; }

		[JsonProperty("started")]
		public bool Started { get; set; }

		[JsonProperty("vendorHash")]
		public uint? VendorHash { get; set; }
	}
}

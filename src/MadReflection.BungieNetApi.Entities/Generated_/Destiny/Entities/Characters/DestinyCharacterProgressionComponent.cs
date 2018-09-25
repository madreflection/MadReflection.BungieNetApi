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

namespace BungieNet.Destiny.Entities.Characters
{
	/// <summary>
	/// This component returns anything that could be considered "Progression" on a user: data where the user is gaining levels, reputation, completions, rewards, etc...
	/// </summary>
	public partial class DestinyCharacterProgressionComponent
	{
		[JsonProperty("progressions")]
		public System.Collections.Generic.Dictionary<uint, Destiny.DestinyProgression> Progressions { get; set; }

		[JsonProperty("factions")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Progression.DestinyFactionProgression> Factions { get; set; }

		[JsonProperty("milestones")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyMilestone> Milestones { get; set; }

		[JsonProperty("quests")]
		public Destiny.Quests.DestinyQuestStatus[] Quests { get; set; }

		[JsonProperty("uninstancedItemObjectives")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Quests.DestinyObjectiveProgress[]> UninstancedItemObjectives { get; set; }

		[JsonProperty("checklists")]
		public System.Collections.Generic.Dictionary<uint, System.Collections.Generic.Dictionary<uint, bool>> Checklists { get; set; }
	}
}

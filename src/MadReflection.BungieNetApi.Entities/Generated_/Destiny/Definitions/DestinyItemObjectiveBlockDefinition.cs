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

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// An item can have objectives on it. In practice, these are the exclusive purview of "Quest Step" items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.
	/// Quest steps have 1:M objectives that we end up processing and returning in live data as DestinyQuestStatus data, and other useful information.
	/// </summary>
	public partial class DestinyItemObjectiveBlockDefinition
	{
		[JsonProperty("objectiveHashes")]
		public uint[] ObjectiveHashes { get; set; }

		[JsonProperty("displayActivityHashes")]
		public uint[] DisplayActivityHashes { get; set; }

		[JsonProperty("requireFullObjectiveCompletion")]
		public bool RequireFullObjectiveCompletion { get; set; }

		[JsonProperty("questlineItemHash")]
		public uint QuestlineItemHash { get; set; }

		[JsonProperty("narrative")]
		public string Narrative { get; set; }

		[JsonProperty("objectiveVerbName")]
		public string ObjectiveVerbName { get; set; }

		[JsonProperty("questTypeIdentifier")]
		public string QuestTypeIdentifier { get; set; }

		[JsonProperty("questTypeHash")]
		public uint QuestTypeHash { get; set; }

		[JsonProperty("perObjectiveDisplayProperties")]
		public Destiny.Definitions.DestinyObjectiveDisplayProperties[] PerObjectiveDisplayProperties { get; set; }

		[JsonProperty("displayAsStatTracker")]
		public bool DisplayAsStatTracker { get; set; }
	}
}

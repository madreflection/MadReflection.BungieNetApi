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

namespace BungieNet.Destiny.Quests
{
	/// <summary>
	/// Returns data about a character's status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
	/// </summary>
	public partial class DestinyObjectiveProgress
	{
		[JsonProperty("objectiveHash")]
		public uint ObjectiveHash { get; set; }

		[JsonProperty("destinationHash")]
		public uint? DestinationHash { get; set; }

		[JsonProperty("activityHash")]
		public uint? ActivityHash { get; set; }

		[JsonProperty("progress")]
		public int? Progress { get; set; }

		[JsonProperty("completionValue")]
		public int CompletionValue { get; set; }

		[JsonProperty("complete")]
		public bool Complete { get; set; }

		[JsonProperty("visible")]
		public bool Visible { get; set; }
	}
}

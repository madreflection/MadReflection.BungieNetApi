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

namespace BungieNet.Destiny.Milestones
{
	/// <summary>
	/// A milestone may have one or more conceptual Activities associated with it, and each of those conceptual activities could have a variety of variants, modes, tiers, what-have-you. Our attempts to determine what qualifies as a conceptual activity are, unfortunately, janky. So if you see missing modes or modes that don't seem appropriate to you, let us know and I'll buy you a beer if we ever meet up in person.
	/// </summary>
	public partial class DestinyPublicMilestoneActivity
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("modifierHashes")]
		public uint[] ModifierHashes { get; set; }

		[JsonProperty("variants")]
		public Destiny.Milestones.DestinyPublicMilestoneActivityVariant[] Variants { get; set; }

		[JsonProperty("activityModeHash")]
		public uint? ActivityModeHash { get; set; }

		[JsonProperty("activityModeType")]
		public Destiny.HistoricalStats.Definitions.DestinyActivityModeType? ActivityModeType { get; set; }
	}
}

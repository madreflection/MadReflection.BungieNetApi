﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Milestones
{
	/// <summary>
	/// Sometimes, we know the specific activity that the Milestone wants you to play. This entity provides additional information about that Activity and all of its variants. (sometimes there's only one variant, but I think you get the point)
	/// </summary>
	public partial class DestinyMilestoneActivity
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("activityModeHash")]
		public uint? ActivityModeHash { get; set; }

		[JsonProperty("activityModeType")]
		public Destiny.HistoricalStats.Definitions.DestinyActivityModeType? ActivityModeType { get; set; }

		[JsonProperty("modifierHashes")]
		public uint[] ModifierHashes { get; set; }

		[JsonProperty("variants")]
		public Destiny.Milestones.DestinyMilestoneActivityVariant[] Variants { get; set; }
	}
}
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

namespace BungieNet.Destiny.HistoricalStats
{
	public partial class DestinyPostGameCarnageReportData
	{
		[JsonProperty("period")]
		public DateTime Period { get; set; }

		[JsonProperty("startingPhaseIndex")]
		public int? StartingPhaseIndex { get; set; }

		[JsonProperty("activityWasStartedFromBeginning")]
		public bool? ActivityWasStartedFromBeginning { get; set; }

		[JsonProperty("activityDetails")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsActivity ActivityDetails { get; set; }

		[JsonProperty("entries")]
		public Destiny.HistoricalStats.DestinyPostGameCarnageReportEntry[] Entries { get; set; }

		[JsonProperty("teams")]
		public Destiny.HistoricalStats.DestinyPostGameCarnageReportTeamEntry[] Teams { get; set; }
	}
}

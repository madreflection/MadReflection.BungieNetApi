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
	public partial class DestinyHistoricalStatsPeriodGroup
	{
		[JsonProperty("period")]
		public DateTime Period { get; set; }

		[JsonProperty("activityDetails")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsActivity ActivityDetails { get; set; }

		[JsonProperty("values")]
		public System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsValue> Values { get; set; }
	}
}

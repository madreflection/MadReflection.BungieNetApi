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
	public partial class DestinyHistoricalStatsValue
	{
		[JsonProperty("statId")]
		public string StatId { get; set; }

		[JsonProperty("basic")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsValuePair Basic { get; set; }

		[JsonProperty("pga")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsValuePair Pga { get; set; }

		[JsonProperty("weighted")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsValuePair Weighted { get; set; }

		[JsonProperty("activityId")]
		public long? ActivityId { get; set; }
	}
}

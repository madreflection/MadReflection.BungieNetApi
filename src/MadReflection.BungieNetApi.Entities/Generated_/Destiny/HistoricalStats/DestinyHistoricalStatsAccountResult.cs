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
	public partial class DestinyHistoricalStatsAccountResult
	{
		[JsonProperty("mergedDeletedCharacters")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }

		[JsonProperty("mergedAllCharacters")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }

		[JsonProperty("characters")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsPerCharacter[] Characters { get; set; }
	}
}

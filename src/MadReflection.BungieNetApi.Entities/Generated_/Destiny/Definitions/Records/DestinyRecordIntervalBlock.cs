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

namespace BungieNet.Destiny.Definitions.Records
{
	public partial class DestinyRecordIntervalBlock
	{
		[JsonProperty("intervalObjectives")]
		public Destiny.Definitions.Records.DestinyRecordIntervalObjective[] IntervalObjectives { get; set; }

		[JsonProperty("intervalRewards")]
		public Destiny.Definitions.Records.DestinyRecordIntervalRewards[] IntervalRewards { get; set; }

		[JsonProperty("originalObjectiveArrayInsertionIndex")]
		public int OriginalObjectiveArrayInsertionIndex { get; set; }
	}
}

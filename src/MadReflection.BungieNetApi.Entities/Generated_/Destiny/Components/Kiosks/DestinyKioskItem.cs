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

namespace BungieNet.Destiny.Components.Kiosks
{
	public partial class DestinyKioskItem
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("canAcquire")]
		public bool CanAcquire { get; set; }

		[JsonProperty("failureIndexes")]
		public int[] FailureIndexes { get; set; }

		[JsonProperty("flavorObjective")]
		public Destiny.Quests.DestinyObjectiveProgress FlavorObjective { get; set; }
	}
}

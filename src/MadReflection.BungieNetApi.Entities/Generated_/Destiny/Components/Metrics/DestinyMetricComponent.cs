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

namespace BungieNet.Destiny.Components.Metrics
{
	public partial class DestinyMetricComponent
	{
		[JsonProperty("invisible")]
		public bool Invisible { get; set; }

		[JsonProperty("objectiveProgress")]
		public Destiny.Quests.DestinyObjectiveProgress ObjectiveProgress { get; set; }
	}
}

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

namespace BungieNet.Destiny.Definitions
{
	public partial class DestinyArrangementRegionFilterDefinition
	{
		[JsonProperty("artArrangementRegionHash")]
		public uint ArtArrangementRegionHash { get; set; }

		[JsonProperty("artArrangementRegionIndex")]
		public int ArtArrangementRegionIndex { get; set; }

		[JsonProperty("statHash")]
		public uint StatHash { get; set; }

		[JsonProperty("arrangementIndexByStatValue")]
		public System.Collections.Generic.Dictionary<int, int> ArrangementIndexByStatValue { get; set; }
	}
}

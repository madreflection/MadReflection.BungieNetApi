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

namespace BungieNet.Destiny
{
	/// <summary>
	/// Represents a stat on an item *or* Character (NOT a Historical Stat, but a physical attribute stat like Attack, Defense etc...)
	/// </summary>
	public partial class DestinyStat
	{
		[JsonProperty("statHash")]
		public uint StatHash { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }
	}
}

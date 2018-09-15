﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// If an item has a related gearset, this is the list of items in that set, and an unlock expression that evaluates to a number representing the progress toward gearset completion (a very rare use for unlock expressions!)
	/// </summary>
	public partial class DestinyItemGearsetBlockDefinition
	{
		[JsonProperty("trackingValueMax")]
		public int TrackingValueMax { get; set; }

		[JsonProperty("itemList")]
		public uint[] ItemList { get; set; }
	}
}

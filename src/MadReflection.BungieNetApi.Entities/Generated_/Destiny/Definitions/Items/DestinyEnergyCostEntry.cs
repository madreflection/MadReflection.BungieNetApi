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

namespace BungieNet.Destiny.Definitions.Items
{
	/// <summary>
	/// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a "masterworks-like" mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
	/// </summary>
	public partial class DestinyEnergyCostEntry
	{
		[JsonProperty("energyCost")]
		public int EnergyCost { get; set; }

		[JsonProperty("energyTypeHash")]
		public uint EnergyTypeHash { get; set; }

		[JsonProperty("energyType")]
		public Destiny.DestinyEnergyType EnergyType { get; set; }
	}
}

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
	/// Defines a particular entry in an ItemSet (AKA a particular Quest Step in a Quest)
	/// </summary>
	public partial class DestinyItemSetBlockEntryDefinition
	{
		[JsonProperty("trackingValue")]
		public int TrackingValue { get; set; }

		[JsonProperty("itemHash")]
		public uint ItemHash { get; set; }
	}
}
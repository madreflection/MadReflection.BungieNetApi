﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Lore
{
	/// <summary>
	/// These are definitions for in-game "Lore," meant to be narrative enhancements of the game experience.
	/// DestinyInventoryItemDefinitions for interesting items point to these definitions, but nothing's stopping you from scraping all of these and doing something cool with them. If they end up having cool data.
	/// </summary>
	public partial class DestinyLoreDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("subtitle")]
		public string Subtitle { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}
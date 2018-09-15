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
	/// An intrinsic perk on an item, and the requirements for it to be activated.
	/// </summary>
	public partial class DestinyItemPerkEntryDefinition
	{
		[JsonProperty("requirementDisplayString")]
		public string RequirementDisplayString { get; set; }

		[JsonProperty("perkHash")]
		public uint PerkHash { get; set; }

		[JsonProperty("perkVisibility")]
		public Destiny.ItemPerkVisibility PerkVisibility { get; set; }
	}
}

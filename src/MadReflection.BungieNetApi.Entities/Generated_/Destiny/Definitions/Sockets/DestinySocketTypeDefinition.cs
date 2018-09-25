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

namespace BungieNet.Destiny.Definitions.Sockets
{
	/// <summary>
	/// All Sockets have a "Type": a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.
	/// See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.
	/// </summary>
	public partial class DestinySocketTypeDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("insertAction")]
		public Destiny.Definitions.Sockets.DestinyInsertPlugActionDefinition InsertAction { get; set; }

		[JsonProperty("plugWhitelist")]
		public Destiny.Definitions.Sockets.DestinyPlugWhitelistEntryDefinition[] PlugWhitelist { get; set; }

		[JsonProperty("socketCategoryHash")]
		public uint SocketCategoryHash { get; set; }

		[JsonProperty("visibility")]
		public Destiny.DestinySocketVisibility Visibility { get; set; }

		[JsonProperty("alwaysRandomizeSockets")]
		public bool AlwaysRandomizeSockets { get; set; }

		[JsonProperty("isPreviewEnabled")]
		public bool IsPreviewEnabled { get; set; }

		[JsonProperty("hideDuplicateReusablePlugs")]
		public bool HideDuplicateReusablePlugs { get; set; }

		[JsonProperty("overridesUiAppearance")]
		public bool OverridesUiAppearance { get; set; }

		[JsonProperty("avoidDuplicatesOnInitialization")]
		public bool AvoidDuplicatesOnInitialization { get; set; }

		[JsonProperty("currencyScalars")]
		public Destiny.Definitions.Sockets.DestinySocketTypeScalarMaterialRequirementEntry[] CurrencyScalars { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}

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

namespace BungieNet.Tokens
{
	public partial class CollectibleDefinitions
	{
		[JsonProperty("CollectibleDefinition")]
		public Destiny.Definitions.Collectibles.DestinyCollectibleDefinition CollectibleDefinition { get; set; }

		[JsonProperty("DestinyInventoryItemDefinition")]
		public Destiny.Definitions.DestinyInventoryItemDefinition DestinyInventoryItemDefinition { get; set; }
	}
}

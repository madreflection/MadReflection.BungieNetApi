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

namespace BungieNet.Destiny.Entities.Items
{
	/// <summary>
	/// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
	/// </summary>
	public partial class DestinyItemRenderComponent
	{
		[JsonProperty("useCustomDyes")]
		public bool UseCustomDyes { get; set; }

		[JsonProperty("artRegions")]
		public System.Collections.Generic.Dictionary<int, int> ArtRegions { get; set; }
	}
}

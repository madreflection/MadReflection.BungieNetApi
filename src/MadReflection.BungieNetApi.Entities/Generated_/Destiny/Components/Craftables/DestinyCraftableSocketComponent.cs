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

namespace BungieNet.Destiny.Components.Craftables
{
	public partial class DestinyCraftableSocketComponent
	{
		[JsonProperty("plugSetHash")]
		public uint PlugSetHash { get; set; }

		[JsonProperty("plugs")]
		public Destiny.Components.Craftables.DestinyCraftableSocketPlugComponent[] Plugs { get; set; }
	}
}
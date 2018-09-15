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
	/// Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.
	/// </summary>
	public partial class DestinyItemIntrinsicSocketEntryDefinition
	{
		[JsonProperty("plugItemHash")]
		public uint PlugItemHash { get; set; }

		[JsonProperty("socketTypeHash")]
		public uint SocketTypeHash { get; set; }
	}
}

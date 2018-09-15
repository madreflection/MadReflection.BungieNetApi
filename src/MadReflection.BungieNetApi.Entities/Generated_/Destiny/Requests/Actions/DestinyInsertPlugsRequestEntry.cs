﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Requests.Actions
{
	/// <summary>
	/// Represents all of the data related to a single plug to be inserted.
	/// Note that, while you *can* point to a socket that represents infusion, you will receive an error if you attempt to do so. Come on guys, let's play nice.
	/// </summary>
	public partial class DestinyInsertPlugsRequestEntry
	{
		[JsonProperty("socketIndex")]
		public int SocketIndex { get; set; }

		[JsonProperty("socketArrayType")]
		public Destiny.Requests.Actions.DestinySocketArrayType SocketArrayType { get; set; }

		[JsonProperty("plugItemHash")]
		public uint PlugItemHash { get; set; }
	}
}

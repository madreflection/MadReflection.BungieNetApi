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

namespace BungieNet.Destiny.Definitions.Director
{
	/// <summary>
	/// Represents a single state that a graph node might end up in. Depending on what's going on in the game, graph nodes could be shown in different ways or even excluded from view entirely.
	/// </summary>
	public partial class DestinyActivityGraphNodeStateEntry
	{
		[JsonProperty("state")]
		public Destiny.DestinyGraphNodeState State { get; set; }
	}
}

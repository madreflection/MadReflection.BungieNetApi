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
	/// The list of indexes into the Talent Grid's "nodes" property for nodes in this exclusive set. (See DestinyTalentNodeDefinition.nodeIndex)
	/// </summary>
	public partial class DestinyTalentNodeExclusiveSetDefinition
	{
		[JsonProperty("nodeIndexes")]
		public int[] NodeIndexes { get; set; }
	}
}
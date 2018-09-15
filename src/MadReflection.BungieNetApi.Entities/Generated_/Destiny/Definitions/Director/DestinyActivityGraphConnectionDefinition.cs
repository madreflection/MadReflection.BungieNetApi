﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Director
{
	/// <summary>
	/// Nodes on a graph can be visually connected: this appears to be the information about which nodes to link. It appears to lack more detailed information, such as the path for that linking.
	/// </summary>
	public partial class DestinyActivityGraphConnectionDefinition
	{
		[JsonProperty("sourceNodeHash")]
		public uint SourceNodeHash { get; set; }

		[JsonProperty("destNodeHash")]
		public uint DestNodeHash { get; set; }
	}
}

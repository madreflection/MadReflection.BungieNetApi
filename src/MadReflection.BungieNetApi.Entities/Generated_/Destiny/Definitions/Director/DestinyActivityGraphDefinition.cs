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
	/// Represents a Map View in the director: be them overview views, destination views, or other.
	/// They have nodes which map to activities, and other various visual elements that we (or others) may or may not be able to use.
	/// Activity graphs, most importantly, have nodes which can have activities in various states of playability.
	/// Unfortunately, activity graphs are combined at runtime with Game UI-only assets such as fragments of map images, various in-game special effects, decals etc... that we don't get in these definitions.
	/// If we end up having time, we may end up trying to manually populate those here: but the last time we tried that, before the lead-up to D1, it proved to be unmaintainable as the game's content changed. So don't bet the farm on us providing that content in this definition.
	/// </summary>
	public partial class DestinyActivityGraphDefinition
	{
		[JsonProperty("nodes")]
		public Destiny.Definitions.Director.DestinyActivityGraphNodeDefinition[] Nodes { get; set; }

		[JsonProperty("artElements")]
		public Destiny.Definitions.Director.DestinyActivityGraphArtElementDefinition[] ArtElements { get; set; }

		[JsonProperty("connections")]
		public Destiny.Definitions.Director.DestinyActivityGraphConnectionDefinition[] Connections { get; set; }

		[JsonProperty("displayObjectives")]
		public Destiny.Definitions.Director.DestinyActivityGraphDisplayObjectiveDefinition[] DisplayObjectives { get; set; }

		[JsonProperty("displayProgressions")]
		public Destiny.Definitions.Director.DestinyActivityGraphDisplayProgressionDefinition[] DisplayProgressions { get; set; }

		[JsonProperty("linkedGraphs")]
		public Destiny.Definitions.Director.DestinyLinkedGraphDefinition[] LinkedGraphs { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}

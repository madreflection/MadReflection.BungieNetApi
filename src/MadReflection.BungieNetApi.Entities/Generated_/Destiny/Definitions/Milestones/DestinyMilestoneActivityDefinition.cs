﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Milestones
{
	/// <summary>
	/// Milestones can have associated activities which provide additional information about the context, challenges, modifiers, state etc... related to this Milestone. 
	/// Information we need to be able to return that data is defined here, along with Tier data to establish a relationship between a conceptual Activity and its difficulty levels and variants.
	/// </summary>
	public partial class DestinyMilestoneActivityDefinition
	{
		[JsonProperty("conceptualActivityHash")]
		public uint ConceptualActivityHash { get; set; }

		[JsonProperty("variants")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Definitions.Milestones.DestinyMilestoneActivityVariantDefinition> Variants { get; set; }
	}
}
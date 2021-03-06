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

namespace BungieNet.Destiny.Definitions.Presentation
{
	/// <summary>
	/// A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.
	/// For now, Presentation Nodes may contain the following... but it may be used for more in the future:
	/// - Collectibles - Records (Or, as the public will call them, "Triumphs." Don't ask me why we're overloading the term "Triumph", it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created
	/// Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the "bare metal" presentation node concept has resulted in me deciding against that for the time being.
	/// We'll see if I come to regret this as well.
	/// </summary>
	public partial class DestinyPresentationNodeDefinition : Destiny.Definitions.DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("originalIcon")]
		public string OriginalIcon { get; set; }

		[JsonProperty("rootViewIcon")]
		public string RootViewIcon { get; set; }

		[JsonProperty("nodeType")]
		public Destiny.DestinyPresentationNodeType NodeType { get; set; }

		[JsonProperty("scope")]
		public Destiny.DestinyScope Scope { get; set; }

		[JsonProperty("objectiveHash")]
		public uint? ObjectiveHash { get; set; }

		[JsonProperty("completionRecordHash")]
		public uint? CompletionRecordHash { get; set; }

		[JsonProperty("children")]
		public Destiny.Definitions.Presentation.DestinyPresentationNodeChildrenBlock Children { get; set; }

		[JsonProperty("displayStyle")]
		public Destiny.DestinyPresentationDisplayStyle DisplayStyle { get; set; }

		[JsonProperty("screenStyle")]
		public Destiny.DestinyPresentationScreenStyle ScreenStyle { get; set; }

		[JsonProperty("requirements")]
		public Destiny.Definitions.Presentation.DestinyPresentationNodeRequirementsBlock Requirements { get; set; }

		[JsonProperty("disableChildSubscreenNavigation")]
		public bool DisableChildSubscreenNavigation { get; set; }

		[JsonProperty("maxCategoryRecordScore")]
		public int MaxCategoryRecordScore { get; set; }

		[JsonProperty("presentationNodeType")]
		public Destiny.DestinyPresentationNodeType PresentationNodeType { get; set; }

		[JsonProperty("traitIds")]
		public string[] TraitIds { get; set; }

		[JsonProperty("traitHashes")]
		public uint[] TraitHashes { get; set; }

		[JsonProperty("parentNodeHashes")]
		public uint[] ParentNodeHashes { get; set; }
	}
}

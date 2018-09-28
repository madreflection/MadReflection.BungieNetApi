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

namespace BungieNet.Destiny.Definitions.Items
{
	/// <summary>
	/// If an item is a Plug, its DestinyInventoryItemDefinition.plug property will be populated with an instance of one of these bad boys.
	/// This gives information about when it can be inserted, what the plug's category is (and thus whether it is compatible with a socket... see DestinySocketTypeDefinition for information about Plug Categories and socket compatibility), whether it is enabled and other Plug info.
	/// </summary>
	public partial class DestinyItemPlugDefinition
	{
		[JsonProperty("insertionRules")]
		public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] InsertionRules { get; set; }

		[JsonProperty("plugCategoryIdentifier")]
		public string PlugCategoryIdentifier { get; set; }

		[JsonProperty("plugCategoryHash")]
		public uint PlugCategoryHash { get; set; }

		[JsonProperty("onActionRecreateSelf")]
		public bool OnActionRecreateSelf { get; set; }

		[JsonProperty("insertionMaterialRequirementHash")]
		public uint InsertionMaterialRequirementHash { get; set; }

		[JsonProperty("previewItemOverrideHash")]
		public uint PreviewItemOverrideHash { get; set; }

		[JsonProperty("enabledMaterialRequirementHash")]
		public uint EnabledMaterialRequirementHash { get; set; }

		[JsonProperty("enabledRules")]
		public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] EnabledRules { get; set; }

		[JsonProperty("uiPlugLabel")]
		public string UIPlugLabel { get; set; }

		[JsonProperty("plugStyle")]
		public Destiny.PlugUiStyles PlugStyle { get; set; }

		[JsonProperty("isPseudoPlug")]
		public bool IsPseudoPlug { get; set; }

		[JsonProperty("plugAvailability")]
		public Destiny.PlugAvailabilityMode PlugAvailability { get; set; }

		[JsonProperty("alternateUiPlugLabel")]
		public string AlternateUiPlugLabel { get; set; }

		[JsonProperty("alternatePlugStyle")]
		public Destiny.PlugUiStyles AlternatePlugStyle { get; set; }

		[JsonProperty("isDummyPlug")]
		public bool IsDummyPlug { get; set; }

		[JsonProperty("parentItemOverride")]
		public Destiny.Definitions.Items.DestinyParentItemOverride ParentItemOverride { get; set; }
	}
}

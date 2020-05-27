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

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.
	/// In practice, you will want to associate this data with "live" item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
	/// </summary>
	public partial class DestinyInventoryItemDefinition : Destiny.Definitions.DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("tooltipNotifications")]
		public Destiny.Definitions.DestinyItemTooltipNotification[] TooltipNotifications { get; set; }

		[JsonProperty("collectibleHash")]
		public uint? CollectibleHash { get; set; }

		[JsonProperty("secondaryIcon")]
		public string SecondaryIcon { get; set; }

		[JsonProperty("secondaryOverlay")]
		public string SecondaryOverlay { get; set; }

		[JsonProperty("secondarySpecial")]
		public string SecondarySpecial { get; set; }

		[JsonProperty("backgroundColor")]
		public Destiny.Misc.DestinyColor BackgroundColor { get; set; }

		[JsonProperty("screenshot")]
		public string Screenshot { get; set; }

		[JsonProperty("itemTypeDisplayName")]
		public string ItemTypeDisplayName { get; set; }

		[JsonProperty("uiItemDisplayStyle")]
		public string UIItemDisplayStyle { get; set; }

		[JsonProperty("itemTypeAndTierDisplayName")]
		public string ItemTypeAndTierDisplayName { get; set; }

		[JsonProperty("displaySource")]
		public string DisplaySource { get; set; }

		[JsonProperty("tooltipStyle")]
		public string TooltipStyle { get; set; }

		[JsonProperty("action")]
		public Destiny.Definitions.DestinyItemActionBlockDefinition Action { get; set; }

		[JsonProperty("inventory")]
		public Destiny.Definitions.DestinyItemInventoryBlockDefinition Inventory { get; set; }

		[JsonProperty("setData")]
		public Destiny.Definitions.DestinyItemSetBlockDefinition SetData { get; set; }

		[JsonProperty("stats")]
		public Destiny.Definitions.DestinyItemStatBlockDefinition Stats { get; set; }

		[JsonProperty("emblemObjectiveHash")]
		public uint? EmblemObjectiveHash { get; set; }

		[JsonProperty("equippingBlock")]
		public Destiny.Definitions.DestinyEquippingBlockDefinition EquippingBlock { get; set; }

		[JsonProperty("translationBlock")]
		public Destiny.Definitions.DestinyItemTranslationBlockDefinition TranslationBlock { get; set; }

		[JsonProperty("preview")]
		public Destiny.Definitions.DestinyItemPreviewBlockDefinition Preview { get; set; }

		[JsonProperty("quality")]
		public Destiny.Definitions.DestinyItemQualityBlockDefinition Quality { get; set; }

		[JsonProperty("value")]
		public Destiny.Definitions.DestinyItemValueBlockDefinition Value { get; set; }

		[JsonProperty("sourceData")]
		public Destiny.Definitions.DestinyItemSourceBlockDefinition SourceData { get; set; }

		[JsonProperty("objectives")]
		public Destiny.Definitions.DestinyItemObjectiveBlockDefinition Objectives { get; set; }

		[JsonProperty("metrics")]
		public Destiny.Definitions.DestinyItemMetricBlockDefinition Metrics { get; set; }

		[JsonProperty("plug")]
		public Destiny.Definitions.Items.DestinyItemPlugDefinition Plug { get; set; }

		[JsonProperty("gearset")]
		public Destiny.Definitions.DestinyItemGearsetBlockDefinition Gearset { get; set; }

		[JsonProperty("sack")]
		public Destiny.Definitions.DestinyItemSackBlockDefinition Sack { get; set; }

		[JsonProperty("sockets")]
		public Destiny.Definitions.DestinyItemSocketBlockDefinition Sockets { get; set; }

		[JsonProperty("summary")]
		public Destiny.Definitions.DestinyItemSummaryBlockDefinition Summary { get; set; }

		[JsonProperty("talentGrid")]
		public Destiny.Definitions.DestinyItemTalentGridBlockDefinition TalentGrid { get; set; }

		[JsonProperty("investmentStats")]
		public Destiny.Definitions.DestinyItemInvestmentStatDefinition[] InvestmentStats { get; set; }

		[JsonProperty("perks")]
		public Destiny.Definitions.DestinyItemPerkEntryDefinition[] Perks { get; set; }

		[JsonProperty("loreHash")]
		public uint? LoreHash { get; set; }

		[JsonProperty("summaryItemHash")]
		public uint? SummaryItemHash { get; set; }

		[JsonProperty("animations")]
		public Destiny.Definitions.Animations.DestinyAnimationReference[] Animations { get; set; }

		[JsonProperty("allowActions")]
		public bool AllowActions { get; set; }

		[JsonProperty("links")]
		public Links.HyperlinkReference[] Links { get; set; }

		[JsonProperty("doesPostmasterPullHaveSideEffects")]
		public bool DoesPostmasterPullHaveSideEffects { get; set; }

		[JsonProperty("nonTransferrable")]
		public bool NonTransferrable { get; set; }

		[JsonProperty("itemCategoryHashes")]
		public uint[] ItemCategoryHashes { get; set; }

		[JsonProperty("specialItemType")]
		public Destiny.SpecialItemType SpecialItemType { get; set; }

		[JsonProperty("itemType")]
		public Destiny.DestinyItemType ItemType { get; set; }

		[JsonProperty("itemSubType")]
		public Destiny.DestinyItemSubType ItemSubType { get; set; }

		[JsonProperty("classType")]
		public Destiny.DestinyClass ClassType { get; set; }

		[JsonProperty("breakerType")]
		public Destiny.DestinyBreakerType BreakerType { get; set; }

		[JsonProperty("breakerTypeHash")]
		public uint? BreakerTypeHash { get; set; }

		[JsonProperty("equippable")]
		public bool Equippable { get; set; }

		[JsonProperty("damageTypeHashes")]
		public uint[] DamageTypeHashes { get; set; }

		[JsonProperty("damageTypes")]
		public Destiny.DamageType[] DamageTypes { get; set; }

		[JsonProperty("defaultDamageType")]
		public Destiny.DamageType DefaultDamageType { get; set; }

		[JsonProperty("defaultDamageTypeHash")]
		public uint? DefaultDamageTypeHash { get; set; }

		[JsonProperty("seasonHash")]
		public uint? SeasonHash { get; set; }

		[JsonProperty("isWrapper")]
		public bool IsWrapper { get; set; }

		[JsonProperty("traitIds")]
		public string[] TraitIds { get; set; }
	}
}

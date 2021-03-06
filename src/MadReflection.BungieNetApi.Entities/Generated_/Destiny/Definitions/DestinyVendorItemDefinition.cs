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
	/// This represents an item being sold by the vendor.
	/// </summary>
	public partial class DestinyVendorItemDefinition
	{
		[JsonProperty("vendorItemIndex")]
		public int VendorItemIndex { get; set; }

		[JsonProperty("itemHash")]
		public uint ItemHash { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("failureIndexes")]
		public int[] FailureIndexes { get; set; }

		[JsonProperty("currencies")]
		public Destiny.Definitions.DestinyVendorItemQuantity[] Currencies { get; set; }

		[JsonProperty("refundPolicy")]
		public Destiny.DestinyVendorItemRefundPolicy RefundPolicy { get; set; }

		[JsonProperty("refundTimeLimit")]
		public int RefundTimeLimit { get; set; }

		[JsonProperty("creationLevels")]
		public Destiny.Definitions.DestinyItemCreationEntryLevelDefinition[] CreationLevels { get; set; }

		[JsonProperty("displayCategoryIndex")]
		public int DisplayCategoryIndex { get; set; }

		[JsonProperty("categoryIndex")]
		public int CategoryIndex { get; set; }

		[JsonProperty("originalCategoryIndex")]
		public int OriginalCategoryIndex { get; set; }

		[JsonProperty("minimumLevel")]
		public int MinimumLevel { get; set; }

		[JsonProperty("maximumLevel")]
		public int MaximumLevel { get; set; }

		[JsonProperty("action")]
		public Destiny.Definitions.DestinyVendorSaleItemActionBlockDefinition Action { get; set; }

		[JsonProperty("displayCategory")]
		public string DisplayCategory { get; set; }

		[JsonProperty("inventoryBucketHash")]
		public uint InventoryBucketHash { get; set; }

		[JsonProperty("visibilityScope")]
		public Destiny.DestinyGatingScope VisibilityScope { get; set; }

		[JsonProperty("purchasableScope")]
		public Destiny.DestinyGatingScope PurchasableScope { get; set; }

		[JsonProperty("exclusivity")]
		public BungieMembershipType Exclusivity { get; set; }

		[JsonProperty("isOffer")]
		public bool? IsOffer { get; set; }

		[JsonProperty("isCrm")]
		public bool? IsCrm { get; set; }

		[JsonProperty("sortValue")]
		public int SortValue { get; set; }

		[JsonProperty("expirationTooltip")]
		public string ExpirationTooltip { get; set; }

		[JsonProperty("redirectToSaleIndexes")]
		public int[] RedirectToSaleIndexes { get; set; }

		[JsonProperty("socketOverrides")]
		public Destiny.Definitions.DestinyVendorItemSocketOverride[] SocketOverrides { get; set; }

		[JsonProperty("unpurchasable")]
		public bool? Unpurchasable { get; set; }
	}
}

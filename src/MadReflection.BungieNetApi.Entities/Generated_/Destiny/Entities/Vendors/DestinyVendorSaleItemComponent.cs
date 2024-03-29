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

namespace BungieNet.Destiny.Entities.Vendors
{
	/// <summary>
	/// Request this component if you want the details about an item being sold in relation to the character making the request: whether the character can buy it, whether they can afford it, and other data related to purchasing the item.
	/// Note that if you want instance, stats, etc... data for the item, you'll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse's "items" property.
	/// </summary>
	public partial class DestinyVendorSaleItemComponent
	{
		[JsonProperty("saleStatus")]
		public Destiny.VendorItemStatus SaleStatus { get; set; }

		[JsonProperty("requiredUnlocks")]
		public uint[] RequiredUnlocks { get; set; }

		[JsonProperty("unlockStatuses")]
		public Destiny.DestinyUnlockStatus[] UnlockStatuses { get; set; }

		[JsonProperty("failureIndexes")]
		public int[] FailureIndexes { get; set; }

		[JsonProperty("augments")]
		public Destiny.DestinyVendorItemState Augments { get; set; }

		[JsonProperty("itemValueVisibility")]
		public bool[] ItemValueVisibility { get; set; }

		[JsonProperty("vendorItemIndex")]
		public int VendorItemIndex { get; set; }

		[JsonProperty("itemHash")]
		public uint ItemHash { get; set; }

		[JsonProperty("overrideStyleItemHash")]
		public uint? OverrideStyleItemHash { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("costs")]
		public Destiny.DestinyItemQuantity[] Costs { get; set; }

		[JsonProperty("overrideNextRefreshDate")]
		public DateTime? OverrideNextRefreshDate { get; set; }

		[JsonProperty("apiPurchasable")]
		public bool? ApiPurchasable { get; set; }
	}
}

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

namespace BungieNet.Destiny.Components.Vendors
{
	/// <summary>
	/// The base class for Vendor Sale Item data. Has a bunch of character-agnostic state about the item being sold.
	/// Note that if you want instance, stats, etc... data for the item, you'll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse's "items" property.
	/// </summary>
	public partial class DestinyVendorSaleItemBaseComponent
	{
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

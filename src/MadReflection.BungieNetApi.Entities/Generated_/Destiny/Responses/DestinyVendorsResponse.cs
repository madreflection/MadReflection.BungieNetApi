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

namespace BungieNet.Destiny.Responses
{
	/// <summary>
	/// A response containing all of the components for all requested vendors.
	/// </summary>
	public partial class DestinyVendorsResponse
	{
		[JsonProperty("vendorGroups")]
		public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

		[JsonProperty("vendors")]
		public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors { get; set; }

		[JsonProperty("categories")]
		public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }

		[JsonProperty("sales")]
		public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales { get; set; }

		[JsonProperty("itemComponents")]
		public System.Collections.Generic.Dictionary<uint, DestinyItemComponentSetOfint32> ItemComponents { get; set; }

		[JsonProperty("currencyLookups")]
		public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }
	}
}

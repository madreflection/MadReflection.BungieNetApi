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
	/// Information about the category and items currently sold in that category.
	/// </summary>
	public partial class DestinyVendorCategory
	{
		[JsonProperty("displayCategoryIndex")]
		public int DisplayCategoryIndex { get; set; }

		[JsonProperty("itemIndexes")]
		public int[] ItemIndexes { get; set; }
	}
}

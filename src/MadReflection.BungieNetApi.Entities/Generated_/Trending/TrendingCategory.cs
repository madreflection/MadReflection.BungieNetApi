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

namespace BungieNet.Trending
{
	public partial class TrendingCategory
	{
		[JsonProperty("categoryName")]
		public string CategoryName { get; set; }

		[JsonProperty("entries")]
		public SearchResultOfTrendingEntry Entries { get; set; }

		[JsonProperty("categoryId")]
		public string CategoryId { get; set; }
	}
}

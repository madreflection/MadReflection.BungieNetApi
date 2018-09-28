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
	/// <summary>
	/// The list entry view for trending items. Returns just enough to show the item on the trending page.
	/// </summary>
	public partial class TrendingEntry
	{
		[JsonProperty("weight")]
		public decimal Weight { get; set; }

		[JsonProperty("isFeatured")]
		public bool IsFeatured { get; set; }

		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("entityType")]
		public Trending.TrendingEntryType EntityType { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("tagline")]
		public string Tagline { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("startDate")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("endDate")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("webmVideo")]
		public string WebmVideo { get; set; }

		[JsonProperty("mp4Video")]
		public string Mp4Video { get; set; }

		[JsonProperty("featureImage")]
		public string FeatureImage { get; set; }

		[JsonProperty("items")]
		public Trending.TrendingEntry[] Items { get; set; }

		[JsonProperty("creationDate")]
		public DateTime? CreationDate { get; set; }
	}
}

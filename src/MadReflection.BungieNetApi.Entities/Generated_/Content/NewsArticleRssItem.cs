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

namespace BungieNet.Content
{
	public partial class NewsArticleRssItem
	{
		[JsonProperty("Title")]
		public string Title { get; set; }

		[JsonProperty("Link")]
		public string Link { get; set; }

		[JsonProperty("PubDate")]
		public DateTime PubDate { get; set; }

		[JsonProperty("UniqueIdentifier")]
		public string UniqueIdentifier { get; set; }

		[JsonProperty("Description")]
		public string Description { get; set; }

		[JsonProperty("HtmlContent")]
		public string HtmlContent { get; set; }

		[JsonProperty("ImagePath")]
		public string ImagePath { get; set; }

		[JsonProperty("OptionalMobileImagePath")]
		public string OptionalMobileImagePath { get; set; }
	}
}

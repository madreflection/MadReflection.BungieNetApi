﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet
{
	public partial class SearchResultOfContentItemPublicContract
	{
		[JsonProperty("results")]
		public Content.ContentItemPublicContract[] Results { get; set; }

		[JsonProperty("totalResults")]
		public int TotalResults { get; set; }

		[JsonProperty("hasMore")]
		public bool HasMore { get; set; }

		[JsonProperty("query")]
		public Queries.PagedQuery Query { get; set; }

		[JsonProperty("replacementContinuationToken")]
		public string ReplacementContinuationToken { get; set; }

		[JsonProperty("useTotalResults")]
		public bool UseTotalResults { get; set; }
	}
}

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

namespace BungieNet.Tokens
{
	public partial class PartnerOfferHistoryResponse
	{
		[JsonProperty("PartnerOfferKey")]
		public string PartnerOfferKey { get; set; }

		[JsonProperty("MembershipId")]
		public long? MembershipId { get; set; }

		[JsonProperty("MembershipType")]
		public BungieMembershipType? MembershipType { get; set; }

		[JsonProperty("LocalizedName")]
		public string LocalizedName { get; set; }

		[JsonProperty("LocalizedDescription")]
		public string LocalizedDescription { get; set; }

		[JsonProperty("IsConsumable")]
		public bool IsConsumable { get; set; }

		[JsonProperty("QuantityApplied")]
		public int QuantityApplied { get; set; }

		[JsonProperty("ApplyDate")]
		public DateTime? ApplyDate { get; set; }
	}
}

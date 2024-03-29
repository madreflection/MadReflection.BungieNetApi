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
	public partial class RewardAvailabilityModel
	{
		[JsonProperty("HasExistingCode")]
		public bool HasExistingCode { get; set; }

		[JsonProperty("RecordDefinitions")]
		public Destiny.Definitions.Records.DestinyRecordDefinition[] RecordDefinitions { get; set; }

		[JsonProperty("CollectibleDefinitions")]
		public Tokens.CollectibleDefinitions[] CollectibleDefinitions { get; set; }

		[JsonProperty("IsOffer")]
		public bool IsOffer { get; set; }

		[JsonProperty("HasOffer")]
		public bool HasOffer { get; set; }

		[JsonProperty("OfferApplied")]
		public bool OfferApplied { get; set; }

		[JsonProperty("DecryptedToken")]
		public string DecryptedToken { get; set; }

		[JsonProperty("IsLoyaltyReward")]
		public bool IsLoyaltyReward { get; set; }

		[JsonProperty("ShopifyEndDate")]
		public DateTime? ShopifyEndDate { get; set; }

		[JsonProperty("GameEarnByDate")]
		public DateTime GameEarnByDate { get; set; }

		[JsonProperty("RedemptionEndDate")]
		public DateTime RedemptionEndDate { get; set; }
	}
}

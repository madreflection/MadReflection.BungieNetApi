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

namespace BungieNet.Destiny.Requests.Actions
{
	public partial class DestinyItemStateRequest
	{
		[JsonProperty("state")]
		public bool State { get; set; }

		[JsonProperty("itemId")]
		public long ItemId { get; set; }

		[JsonProperty("characterId")]
		public long CharacterId { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }
	}
}

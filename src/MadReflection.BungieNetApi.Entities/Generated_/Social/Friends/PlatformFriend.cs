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

namespace BungieNet.Social.Friends
{
	public partial class PlatformFriend
	{
		[JsonProperty("platformDisplayName")]
		public string PlatformDisplayName { get; set; }

		[JsonProperty("friendPlatform")]
		public Social.Friends.PlatformFriendType FriendPlatform { get; set; }

		[JsonProperty("destinyMembershipId")]
		public long? DestinyMembershipId { get; set; }

		[JsonProperty("destinyMembershipType")]
		public BungieMembershipType? DestinyMembershipType { get; set; }

		[JsonProperty("bungieNetMembershipId")]
		public long? BungieNetMembershipId { get; set; }

		[JsonProperty("bungieGlobalDisplayName")]
		public string BungieGlobalDisplayName { get; set; }

		[JsonProperty("bungieGlobalDisplayNameCode")]
		public short? BungieGlobalDisplayNameCode { get; set; }
	}
}

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

namespace BungieNet.GroupsV2
{
	public partial class GroupUserInfoCard
	{
		[JsonProperty("LastSeenDisplayName")]
		public string LastSeenDisplayName { get; set; }

		[JsonProperty("LastSeenDisplayNameType")]
		public BungieMembershipType LastSeenDisplayNameType { get; set; }

		[JsonProperty("supplementalDisplayName")]
		public string SupplementalDisplayName { get; set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("crossSaveOverride")]
		public BungieMembershipType CrossSaveOverride { get; set; }

		[JsonProperty("applicableMembershipTypes")]
		public BungieMembershipType[] ApplicableMembershipTypes { get; set; }

		[JsonProperty("isPublic")]
		public bool IsPublic { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }

		[JsonProperty("membershipId")]
		public long MembershipId { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }
	}
}

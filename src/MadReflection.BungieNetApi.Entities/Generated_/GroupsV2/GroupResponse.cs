﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.GroupsV2
{
	public partial class GroupResponse
	{
		[JsonProperty("detail")]
		public GroupsV2.GroupV2 Detail { get; set; }

		[JsonProperty("founder")]
		public GroupsV2.GroupMember Founder { get; set; }

		[JsonProperty("alliedIds")]
		public long[] AlliedIds { get; set; }

		[JsonProperty("parentGroup")]
		public GroupsV2.GroupV2 ParentGroup { get; set; }

		[JsonProperty("allianceStatus")]
		public GroupsV2.GroupAllianceStatus AllianceStatus { get; set; }

		[JsonProperty("groupJoinInviteCount")]
		public int GroupJoinInviteCount { get; set; }

		[JsonProperty("currentUserMemberMap")]
		public System.Collections.Generic.Dictionary<BungieMembershipType, GroupsV2.GroupMember> CurrentUserMemberMap { get; set; }

		[JsonProperty("currentUserPotentialMemberMap")]
		public System.Collections.Generic.Dictionary<BungieMembershipType, GroupsV2.GroupPotentialMember> CurrentUserPotentialMemberMap { get; set; }
	}
}

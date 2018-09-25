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
	public partial class GroupV2
	{
		[JsonProperty("groupId")]
		public long GroupId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("groupType")]
		public GroupsV2.GroupType GroupType { get; set; }

		[JsonProperty("membershipIdCreated")]
		public long MembershipIdCreated { get; set; }

		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("modificationDate")]
		public DateTime ModificationDate { get; set; }

		[JsonProperty("about")]
		public string About { get; set; }

		[JsonProperty("tags")]
		public string[] Tags { get; set; }

		[JsonProperty("memberCount")]
		public int MemberCount { get; set; }

		[JsonProperty("isPublic")]
		public bool IsPublic { get; set; }

		[JsonProperty("isPublicTopicAdminOnly")]
		public bool IsPublicTopicAdminOnly { get; set; }

		[JsonProperty("motto")]
		public string Motto { get; set; }

		[JsonProperty("allowChat")]
		public bool AllowChat { get; set; }

		[JsonProperty("isDefaultPostPublic")]
		public bool IsDefaultPostPublic { get; set; }

		[JsonProperty("chatSecurity")]
		public GroupsV2.ChatSecuritySetting ChatSecurity { get; set; }

		[JsonProperty("locale")]
		public string Locale { get; set; }

		[JsonProperty("avatarImageIndex")]
		public int AvatarImageIndex { get; set; }

		[JsonProperty("homepage")]
		public GroupsV2.GroupHomepage Homepage { get; set; }

		[JsonProperty("membershipOption")]
		public GroupsV2.MembershipOption MembershipOption { get; set; }

		[JsonProperty("defaultPublicity")]
		public GroupsV2.GroupPostPublicity DefaultPublicity { get; set; }

		[JsonProperty("theme")]
		public string Theme { get; set; }

		[JsonProperty("bannerPath")]
		public string BannerPath { get; set; }

		[JsonProperty("avatarPath")]
		public string AvatarPath { get; set; }

		[JsonProperty("conversationId")]
		public long ConversationId { get; set; }

		[JsonProperty("enableInvitationMessagingForAdmins")]
		public bool EnableInvitationMessagingForAdmins { get; set; }

		[JsonProperty("banExpireDate")]
		public DateTime? BanExpireDate { get; set; }

		[JsonProperty("features")]
		public GroupsV2.GroupFeatures Features { get; set; }

		[JsonProperty("clanInfo")]
		public GroupsV2.GroupV2ClanInfoAndInvestment ClanInfo { get; set; }
	}
}

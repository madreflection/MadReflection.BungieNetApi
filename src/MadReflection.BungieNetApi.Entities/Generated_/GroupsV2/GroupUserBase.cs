﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.GroupsV2
{
	public partial class GroupUserBase
	{
		[JsonProperty("groupId")]
		public long GroupId { get; set; }

		[JsonProperty("destinyUserInfo")]
		public User.UserInfoCard DestinyUserInfo { get; set; }

		[JsonProperty("bungieNetUserInfo")]
		public User.UserInfoCard BungieNetUserInfo { get; set; }

		[JsonProperty("joinDate")]
		public DateTime JoinDate { get; set; }
	}
}
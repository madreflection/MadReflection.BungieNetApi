﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.GroupsV2
{
	public partial class GroupOptionalConversationAddRequest
	{
		[JsonProperty("chatName")]
		public string ChatName { get; set; }

		[JsonProperty("chatSecurity")]
		public GroupsV2.ChatSecuritySetting ChatSecurity { get; set; }
	}
}

﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.GroupsV2
{
	public partial class GroupMembership
	{
		[JsonProperty("member")]
		public GroupsV2.GroupMember Member { get; set; }

		[JsonProperty("group")]
		public GroupsV2.GroupV2 Group { get; set; }
	}
}

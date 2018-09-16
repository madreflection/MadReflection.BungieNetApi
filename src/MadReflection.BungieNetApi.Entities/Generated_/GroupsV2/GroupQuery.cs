﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.GroupsV2
{
	public partial class GroupQuery
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("groupType")]
		public GroupsV2.GroupType GroupType { get; set; }

		[JsonProperty("creationDate")]
		public GroupsV2.GroupDateRange CreationDate { get; set; }

		[JsonProperty("sortBy")]
		public GroupsV2.GroupSortBy SortBy { get; set; }

		[JsonProperty("groupMemberCountFilter")]
		public GroupsV2.GroupMemberCountFilter? GroupMemberCountFilter { get; set; }

		[JsonProperty("localeFilter")]
		public string LocaleFilter { get; set; }

		[JsonProperty("tagText")]
		public string TagText { get; set; }

		[JsonProperty("itemsPerPage")]
		public int ItemsPerPage { get; set; }

		[JsonProperty("currentPage")]
		public int CurrentPage { get; set; }

		[JsonProperty("requestContinuationToken")]
		public string RequestContinuationToken { get; set; }
	}
}
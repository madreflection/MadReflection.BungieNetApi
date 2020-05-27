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

namespace BungieNet.Fireteam
{
	public partial class FireteamSummary
	{
		[JsonProperty("fireteamId")]
		public long FireteamId { get; set; }

		[JsonProperty("groupId")]
		public long GroupId { get; set; }

		[JsonProperty("platform")]
		public Fireteam.FireteamPlatform Platform { get; set; }

		[JsonProperty("activityType")]
		public int ActivityType { get; set; }

		[JsonProperty("isImmediate")]
		public bool IsImmediate { get; set; }

		[JsonProperty("scheduledTime")]
		public DateTime? ScheduledTime { get; set; }

		[JsonProperty("ownerMembershipId")]
		public long OwnerMembershipId { get; set; }

		[JsonProperty("playerSlotCount")]
		public int PlayerSlotCount { get; set; }

		[JsonProperty("alternateSlotCount")]
		public int? AlternateSlotCount { get; set; }

		[JsonProperty("availablePlayerSlotCount")]
		public int AvailablePlayerSlotCount { get; set; }

		[JsonProperty("availableAlternateSlotCount")]
		public int AvailableAlternateSlotCount { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("dateCreated")]
		public DateTime DateCreated { get; set; }

		[JsonProperty("dateModified")]
		public DateTime? DateModified { get; set; }

		[JsonProperty("isPublic")]
		public bool IsPublic { get; set; }

		[JsonProperty("locale")]
		public string Locale { get; set; }

		[JsonProperty("isValid")]
		public bool IsValid { get; set; }

		[JsonProperty("datePlayerModified")]
		public DateTime DatePlayerModified { get; set; }

		[JsonProperty("titleBeforeModeration")]
		public string TitleBeforeModeration { get; set; }
	}
}

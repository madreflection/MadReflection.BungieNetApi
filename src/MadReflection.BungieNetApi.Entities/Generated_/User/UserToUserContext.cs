﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.User
{
	public partial class UserToUserContext
	{
		[JsonProperty("isFollowing")]
		public bool IsFollowing { get; set; }

		[JsonProperty("ignoreStatus")]
		public Ignores.IgnoreResponse IgnoreStatus { get; set; }

		[JsonProperty("globalIgnoreEndDate")]
		public DateTime? GlobalIgnoreEndDate { get; set; }
	}
}

﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Requests.Actions
{
	public partial class DestinyCharacterActionRequest
	{
		[JsonProperty("characterId")]
		public long CharacterId { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }
	}
}

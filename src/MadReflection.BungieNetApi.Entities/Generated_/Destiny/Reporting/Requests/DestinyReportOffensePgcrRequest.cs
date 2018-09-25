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

namespace BungieNet.Destiny.Reporting.Requests
{
	/// <summary>
	/// If you want to report a player causing trouble in a game, this request will let you report that player and the specific PGCR in which the trouble was caused, along with why.
	/// Please don't do this just because you dislike the person! I mean, I know people will do it anyways, but can you like take a good walk, or put a curse on them or something? Do me a solid and reconsider.
	/// Note that this request object doesn't have the actual PGCR ID nor your Account/Character ID in it. We will infer that information from your authentication information and the PGCR ID that you pass into the URL of the reporting endpoint itself.
	/// </summary>
	public partial class DestinyReportOffensePgcrRequest
	{
		[JsonProperty("reasonCategoryHashes")]
		public uint[] ReasonCategoryHashes { get; set; }

		[JsonProperty("reasonHashes")]
		public uint[] ReasonHashes { get; set; }

		[JsonProperty("offendingCharacterId")]
		public long OffendingCharacterId { get; set; }
	}
}

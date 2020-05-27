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

namespace BungieNet.User
{
	/// <summary>
	/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
	/// </summary>
	public partial class UserInfoCard
	{
		[JsonProperty("supplementalDisplayName")]
		public string SupplementalDisplayName { get; set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("crossSaveOverride")]
		public BungieMembershipType CrossSaveOverride { get; set; }

		[JsonProperty("applicableMembershipTypes")]
		public BungieMembershipType[] ApplicableMembershipTypes { get; set; }

		[JsonProperty("isPublic")]
		public bool IsPublic { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }

		[JsonProperty("membershipId")]
		public long MembershipId { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }
	}
}

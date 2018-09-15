﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Responses
{
	/// <summary>
	/// I know what you seek. You seek linked accounts. Found them, you have.
	/// This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose
	/// </summary>
	public partial class DestinyLinkedProfilesResponse
	{
		[JsonProperty("profiles")]
		public User.UserInfoCard[] Profiles { get; set; }

		[JsonProperty("bnetMembership")]
		public User.UserInfoCard BnetMembership { get; set; }

		[JsonProperty("profilesWithErrors")]
		public Destiny.Responses.DestinyErrorProfile[] ProfilesWithErrors { get; set; }
	}
}

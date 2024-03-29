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

namespace BungieNet.Destiny.Entities.Profiles
{
	/// <summary>
	/// The most essential summary information about a Profile (in Destiny 1, we called these "Accounts").
	/// </summary>
	public partial class DestinyProfileComponent
	{
		[JsonProperty("userInfo")]
		public User.UserInfoCard UserInfo { get; set; }

		[JsonProperty("dateLastPlayed")]
		public DateTime DateLastPlayed { get; set; }

		[JsonProperty("versionsOwned")]
		public Destiny.DestinyGameVersions VersionsOwned { get; set; }

		[JsonProperty("characterIds")]
		public long[] CharacterIds { get; set; }

		[JsonProperty("seasonHashes")]
		public uint[] SeasonHashes { get; set; }

		[JsonProperty("eventCardHashesOwned")]
		public uint[] EventCardHashesOwned { get; set; }

		[JsonProperty("currentSeasonHash")]
		public uint? CurrentSeasonHash { get; set; }

		[JsonProperty("currentSeasonRewardPowerCap")]
		public int? CurrentSeasonRewardPowerCap { get; set; }

		[JsonProperty("activeEventCardHash")]
		public uint? ActiveEventCardHash { get; set; }
	}
}

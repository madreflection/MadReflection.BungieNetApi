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

namespace BungieNet.Destiny.HistoricalStats
{
	public partial class DestinyPlayer
	{
		[JsonProperty("destinyUserInfo")]
		public User.UserInfoCard DestinyUserInfo { get; set; }

		[JsonProperty("characterClass")]
		public string CharacterClass { get; set; }

		[JsonProperty("classHash")]
		public uint ClassHash { get; set; }

		[JsonProperty("raceHash")]
		public uint RaceHash { get; set; }

		[JsonProperty("genderHash")]
		public uint GenderHash { get; set; }

		[JsonProperty("characterLevel")]
		public int CharacterLevel { get; set; }

		[JsonProperty("lightLevel")]
		public int LightLevel { get; set; }

		[JsonProperty("bungieNetUserInfo")]
		public User.UserInfoCard BungieNetUserInfo { get; set; }

		[JsonProperty("clanName")]
		public string ClanName { get; set; }

		[JsonProperty("clanTag")]
		public string ClanTag { get; set; }

		[JsonProperty("emblemHash")]
		public uint EmblemHash { get; set; }
	}
}

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

namespace BungieNet.Destiny.Components.Profiles
{
	/// <summary>
	/// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
	/// </summary>
	public partial class DestinyProfileTransitoryJoinability
	{
		[JsonProperty("openSlots")]
		public int OpenSlots { get; set; }

		[JsonProperty("privacySetting")]
		public Destiny.DestinyGamePrivacySetting PrivacySetting { get; set; }

		[JsonProperty("closedReasons")]
		public Destiny.DestinyJoinClosedReasons ClosedReasons { get; set; }
	}
}

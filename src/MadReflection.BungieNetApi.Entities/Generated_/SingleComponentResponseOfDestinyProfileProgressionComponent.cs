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

namespace BungieNet
{
	public partial class SingleComponentResponseOfDestinyProfileProgressionComponent
	{
		[JsonProperty("data")]
		public Destiny.Components.Profiles.DestinyProfileProgressionComponent Data { get; set; }

		[JsonProperty("privacy")]
		public Components.ComponentPrivacySetting Privacy { get; set; }
	}
}

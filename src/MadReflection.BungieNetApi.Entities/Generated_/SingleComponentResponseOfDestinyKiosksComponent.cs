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
	public partial class SingleComponentResponseOfDestinyKiosksComponent
	{
		[JsonProperty("data")]
		public Destiny.Components.Kiosks.DestinyKiosksComponent Data { get; set; }

		[JsonProperty("privacy")]
		public Components.ComponentPrivacySetting Privacy { get; set; }
	}
}

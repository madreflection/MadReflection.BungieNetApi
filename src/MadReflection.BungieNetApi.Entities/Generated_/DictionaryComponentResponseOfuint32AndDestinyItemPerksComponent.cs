﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet
{
	public partial class DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent
	{
		[JsonProperty("data")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Entities.Items.DestinyItemPerksComponent> Data { get; set; }

		[JsonProperty("privacy")]
		public Components.ComponentPrivacySetting Privacy { get; set; }
	}
}

﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet
{
	public partial class SingleComponentResponseOfDestinyCharacterRecordsComponent
	{
		[JsonProperty("data")]
		public Destiny.Components.Records.DestinyCharacterRecordsComponent Data { get; set; }

		[JsonProperty("privacy")]
		public Components.ComponentPrivacySetting Privacy { get; set; }
	}
}

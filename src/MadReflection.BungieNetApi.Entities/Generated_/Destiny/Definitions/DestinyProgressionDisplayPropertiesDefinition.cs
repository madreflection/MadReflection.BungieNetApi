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

namespace BungieNet.Destiny.Definitions
{
	public partial class DestinyProgressionDisplayPropertiesDefinition
	{
		[JsonProperty("displayUnitsName")]
		public string DisplayUnitsName { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("iconSequences")]
		public Destiny.Definitions.Common.DestinyIconSequenceDefinition[] IconSequences { get; set; }

		[JsonProperty("highResIcon")]
		public string HighResIcon { get; set; }

		[JsonProperty("hasIcon")]
		public bool HasIcon { get; set; }
	}
}

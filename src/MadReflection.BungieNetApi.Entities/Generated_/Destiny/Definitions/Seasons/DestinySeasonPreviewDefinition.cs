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

namespace BungieNet.Destiny.Definitions.Seasons
{
	/// <summary>
	/// Defines the promotional text, images, and links to preview this season.
	/// </summary>
	public partial class DestinySeasonPreviewDefinition
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("linkPath")]
		public string LinkPath { get; set; }

		[JsonProperty("videoLink")]
		public string VideoLink { get; set; }

		[JsonProperty("images")]
		public Destiny.Definitions.Seasons.DestinySeasonPreviewImageDefinition[] Images { get; set; }
	}
}

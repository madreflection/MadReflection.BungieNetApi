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
	/// Defines the thumbnail icon, high-res image, and video link for promotional images
	/// </summary>
	public partial class DestinySeasonPreviewImageDefinition
	{
		[JsonProperty("thumbnailImage")]
		public string ThumbnailImage { get; set; }

		[JsonProperty("highResImage")]
		public string HighResImage { get; set; }
	}
}

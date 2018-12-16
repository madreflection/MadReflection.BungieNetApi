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

namespace BungieNet.Destiny.Config
{
	/// <summary>
	/// DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform.
	/// </summary>
	public partial class DestinyManifest
	{
		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("mobileAssetContentPath")]
		public string MobileAssetContentPath { get; set; }

		[JsonProperty("mobileGearAssetDataBases")]
		public Destiny.Config.GearAssetDataBaseDefinition[] MobileGearAssetDataBases { get; set; }

		[JsonProperty("mobileWorldContentPaths")]
		public System.Collections.Generic.Dictionary<string, string> MobileWorldContentPaths { get; set; }

		[JsonProperty("jsonWorldContentPaths")]
		public System.Collections.Generic.Dictionary<string, string> JsonWorldContentPaths { get; set; }

		[JsonProperty("mobileClanBannerDatabasePath")]
		public string MobileClanBannerDatabasePath { get; set; }

		[JsonProperty("mobileGearCDN")]
		public System.Collections.Generic.Dictionary<string, string> MobileGearCDN { get; set; }
	}
}

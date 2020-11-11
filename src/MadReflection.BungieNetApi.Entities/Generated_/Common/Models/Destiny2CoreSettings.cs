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

namespace BungieNet.Common.Models
{
	public partial class Destiny2CoreSettings
	{
		[JsonProperty("collectionRootNode")]
		public uint CollectionRootNode { get; set; }

		[JsonProperty("badgesRootNode")]
		public uint BadgesRootNode { get; set; }

		[JsonProperty("recordsRootNode")]
		public uint RecordsRootNode { get; set; }

		[JsonProperty("medalsRootNode")]
		public uint MedalsRootNode { get; set; }

		[JsonProperty("metricsRootNode")]
		public uint MetricsRootNode { get; set; }

		[JsonProperty("activeTriumphsRootNodeHash")]
		public uint ActiveTriumphsRootNodeHash { get; set; }

		[JsonProperty("activeSealsRootNodeHash")]
		public uint ActiveSealsRootNodeHash { get; set; }

		[JsonProperty("legacyTriumphsRootNodeHash")]
		public uint LegacyTriumphsRootNodeHash { get; set; }

		[JsonProperty("legacySealsRootNodeHash")]
		public uint LegacySealsRootNodeHash { get; set; }

		[JsonProperty("medalsRootNodeHash")]
		public uint MedalsRootNodeHash { get; set; }

		[JsonProperty("exoticCatalystsRootNodeHash")]
		public uint ExoticCatalystsRootNodeHash { get; set; }

		[JsonProperty("loreRootNodeHash")]
		public uint LoreRootNodeHash { get; set; }

		[JsonProperty("currentRankProgressionHashes")]
		public uint[] CurrentRankProgressionHashes { get; set; }

		[JsonProperty("undiscoveredCollectibleImage")]
		public string UndiscoveredCollectibleImage { get; set; }

		[JsonProperty("ammoTypeHeavyIcon")]
		public string AmmoTypeHeavyIcon { get; set; }

		[JsonProperty("ammoTypeSpecialIcon")]
		public string AmmoTypeSpecialIcon { get; set; }

		[JsonProperty("ammoTypePrimaryIcon")]
		public string AmmoTypePrimaryIcon { get; set; }

		[JsonProperty("currentSeasonalArtifactHash")]
		public uint CurrentSeasonalArtifactHash { get; set; }

		[JsonProperty("currentSeasonHash")]
		public uint? CurrentSeasonHash { get; set; }

		[JsonProperty("futureSeasonHashes")]
		public uint[] FutureSeasonHashes { get; set; }

		[JsonProperty("pastSeasonHashes")]
		public uint[] PastSeasonHashes { get; set; }
	}
}

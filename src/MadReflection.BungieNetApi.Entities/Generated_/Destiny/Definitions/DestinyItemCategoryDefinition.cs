﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it's in, its item type name, and whether it has or is missing certain blocks of data.
	/// This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!
	/// We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
	/// </summary>
	public partial class DestinyItemCategoryDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("visible")]
		public bool Visible { get; set; }

		[JsonProperty("deprecated")]
		public bool Deprecated { get; set; }

		[JsonProperty("shortTitle")]
		public string ShortTitle { get; set; }

		[JsonProperty("itemTypeRegex")]
		public string ItemTypeRegex { get; set; }

		[JsonProperty("plugCategoryIdentifier")]
		public string PlugCategoryIdentifier { get; set; }

		[JsonProperty("itemTypeRegexNot")]
		public string ItemTypeRegexNot { get; set; }

		[JsonProperty("originBucketIdentifier")]
		public string OriginBucketIdentifier { get; set; }

		[JsonProperty("grantDestinyItemType")]
		public Destiny.DestinyItemType GrantDestinyItemType { get; set; }

		[JsonProperty("grantDestinySubType")]
		public Destiny.DestinyItemSubType GrantDestinySubType { get; set; }

		[JsonProperty("grantDestinyClass")]
		public Destiny.DestinyClass GrantDestinyClass { get; set; }

		[JsonProperty("groupedCategoryHashes")]
		public uint[] GroupedCategoryHashes { get; set; }

		[JsonProperty("parentCategoryHashes")]
		public uint[] ParentCategoryHashes { get; set; }

		[JsonProperty("groupCategoryOnly")]
		public bool GroupCategoryOnly { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}
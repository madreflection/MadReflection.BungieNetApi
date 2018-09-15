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
	/// An individual Destiny Entity returned from the entity search.
	/// </summary>
	public partial class DestinyEntitySearchResultItem
	{
		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("entityType")]
		public string EntityType { get; set; }

		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("weight")]
		public double Weight { get; set; }
	}
}

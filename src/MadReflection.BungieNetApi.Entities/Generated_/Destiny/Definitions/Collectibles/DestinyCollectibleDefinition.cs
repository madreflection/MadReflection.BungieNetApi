﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Collectibles
{
	/// <summary>
	/// Defines a
	/// </summary>
	public partial class DestinyCollectibleDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("sourceString")]
		public string SourceString { get; set; }

		[JsonProperty("itemHash")]
		public uint ItemHash { get; set; }

		[JsonProperty("acquisitionInfo")]
		public Destiny.Definitions.Collectibles.DestinyCollectibleAcquisitionBlock AcquisitionInfo { get; set; }

		[JsonProperty("stateInfo")]
		public Destiny.Definitions.Collectibles.DestinyCollectibleStateBlock StateInfo { get; set; }

		[JsonProperty("presentationInfo")]
		public Destiny.Definitions.Presentation.DestinyPresentationChildBlock PresentationInfo { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}

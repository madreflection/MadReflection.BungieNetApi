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

namespace BungieNet.Destiny.Artifacts
{
	/// <summary>
	/// Represents a Seasonal Artifact and all data related to it for the requested Account.
	/// It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
	/// </summary>
	public partial class DestinyArtifactProfileScoped
	{
		[JsonProperty("artifactHash")]
		public uint ArtifactHash { get; set; }

		[JsonProperty("pointProgression")]
		public Destiny.DestinyProgression PointProgression { get; set; }

		[JsonProperty("pointsAcquired")]
		public int PointsAcquired { get; set; }

		[JsonProperty("powerBonusProgression")]
		public Destiny.DestinyProgression PowerBonusProgression { get; set; }

		[JsonProperty("powerBonus")]
		public int PowerBonus { get; set; }
	}
}

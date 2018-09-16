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
	/// In Destiny, "Races" are really more like "Species". Sort of. I mean, are the Awoken a separate species from humans? I'm not sure. But either way, they're defined here. You'll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.
	/// </summary>
	public partial class DestinyRaceDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("raceType")]
		public Destiny.DestinyRace RaceType { get; set; }

		[JsonProperty("genderedRaceNames")]
		public System.Collections.Generic.Dictionary<Destiny.DestinyGender, string> GenderedRaceNames { get; set; }

		[JsonProperty("hash")]
		public uint Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}
}
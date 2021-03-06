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

namespace BungieNet.Destiny.Character
{
	/// <summary>
	/// Raw data about the customization options chosen for a character's face and appearance.
	/// You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
	/// </summary>
	public partial class DestinyCharacterCustomization
	{
		[JsonProperty("personality")]
		public uint Personality { get; set; }

		[JsonProperty("face")]
		public uint Face { get; set; }

		[JsonProperty("skinColor")]
		public uint SkinColor { get; set; }

		[JsonProperty("lipColor")]
		public uint LipColor { get; set; }

		[JsonProperty("eyeColor")]
		public uint EyeColor { get; set; }

		[JsonProperty("hairColors")]
		public uint[] HairColors { get; set; }

		[JsonProperty("featureColors")]
		public uint[] FeatureColors { get; set; }

		[JsonProperty("decalColor")]
		public uint DecalColor { get; set; }

		[JsonProperty("wearHelmet")]
		public bool WearHelmet { get; set; }

		[JsonProperty("hairIndex")]
		public int HairIndex { get; set; }

		[JsonProperty("featureIndex")]
		public int FeatureIndex { get; set; }

		[JsonProperty("decalIndex")]
		public int DecalIndex { get; set; }
	}
}

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

namespace BungieNet.Destiny.Definitions.Traits
{
	public partial class DestinyTraitDefinition : Destiny.Definitions.DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("traitCategoryId")]
		public string TraitCategoryId { get; set; }

		[JsonProperty("traitCategoryHash")]
		public uint TraitCategoryHash { get; set; }

		[JsonProperty("displayHint")]
		public string DisplayHint { get; set; }
	}
}

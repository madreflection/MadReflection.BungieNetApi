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

namespace BungieNet
{
	public partial class DestinyItemComponentSetOfuint32
	{
		[JsonProperty("instances")]
		public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances { get; set; }

		[JsonProperty("renderData")]
		public DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData { get; set; }

		[JsonProperty("stats")]
		public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats { get; set; }

		[JsonProperty("sockets")]
		public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets { get; set; }

		[JsonProperty("reusablePlugs")]
		public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

		[JsonProperty("plugObjectives")]
		public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

		[JsonProperty("talentGrids")]
		public DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }

		[JsonProperty("plugStates")]
		public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }

		[JsonProperty("objectives")]
		public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }

		[JsonProperty("perks")]
		public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks { get; set; }
	}
}

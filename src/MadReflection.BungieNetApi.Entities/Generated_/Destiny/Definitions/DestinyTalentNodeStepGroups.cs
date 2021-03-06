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

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// These properties are an attempt to categorize talent node steps by certain common properties. See the related enumerations for the type of properties being categorized.
	/// </summary>
	public partial class DestinyTalentNodeStepGroups
	{
		[JsonProperty("weaponPerformance")]
		public Destiny.Definitions.DestinyTalentNodeStepWeaponPerformances WeaponPerformance { get; set; }

		[JsonProperty("impactEffects")]
		public Destiny.Definitions.DestinyTalentNodeStepImpactEffects ImpactEffects { get; set; }

		[JsonProperty("guardianAttributes")]
		public Destiny.Definitions.DestinyTalentNodeStepGuardianAttributes GuardianAttributes { get; set; }

		[JsonProperty("lightAbilities")]
		public Destiny.Definitions.DestinyTalentNodeStepLightAbilities LightAbilities { get; set; }

		[JsonProperty("damageTypes")]
		public Destiny.Definitions.DestinyTalentNodeStepDamageTypes DamageTypes { get; set; }
	}
}

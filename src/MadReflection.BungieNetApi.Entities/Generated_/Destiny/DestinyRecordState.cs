﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace BungieNet.Destiny
{
	/// <summary>
	/// A Flags enumeration/bitmask where each bit represents a possible state that a Record/Triumph can be in.
	/// </summary>
	[Flags]
	public enum DestinyRecordState
	{
		/// <summary>
		/// If there are no flags set, the record is in a state where it *could* be redeemed, but it has not been yet.
		/// </summary>
		None = 0x0,

		/// <summary>
		/// If this is set, the completed record has been redeemed.
		/// </summary>
		RecordRedeemed = 0x1,

		/// <summary>
		/// If this is set, there's a reward available from this Record but it's unavailable for redemption.
		/// </summary>
		RewardUnavailable = 0x2,

		/// <summary>
		/// If this is set, the objective for this Record has not yet been completed.
		/// </summary>
		ObjectiveNotCompleted = 0x4,

		/// <summary>
		/// If this is set, the game recommends that you replace the display text of this Record with DestinyRecordDefinition.stateInfo.obscuredString.
		/// </summary>
		Obscured = 0x8,

		/// <summary>
		/// If this is set, the game recommends that you not show this record. Do what you will with this recommendation.
		/// </summary>
		Invisible = 0x10,

		/// <summary>
		/// If this is set, you can't complete this record because you lack some permission that's required to complete it.
		/// </summary>
		EntitlementUnowned = 0x20,

		/// <summary>
		/// If this is set, the record has a title (check DestinyRecordDefinition for title info) and you can equip it.
		/// </summary>
		CanEquipTitle = 0x40
	}
}

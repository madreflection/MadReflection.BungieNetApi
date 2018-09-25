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
	/// An enumeration of the known UI interactions for Vendors.
	/// </summary>
	public enum VendorInteractionType
	{
		Unknown = 0,

		/// <summary>
		/// An interaction shown when you complete a quest and receive a reward.
		/// </summary>
		QuestComplete = 1,

		/// <summary>
		/// An interaction shown when you talk to a Vendor as an intermediary step of a quest.
		/// </summary>
		QuestContinue = 2,

		/// <summary>
		/// An interaction shown when you are previewing the vendor's reputation rewards.
		/// </summary>
		ReputationPreview = 3,

		/// <summary>
		/// An interaction shown when you rank up with the vendor.
		/// </summary>
		RankUpReward = 4,

		/// <summary>
		/// An interaction shown when you have tokens to turn in for the vendor.
		/// </summary>
		TokenTurnIn = 5,

		/// <summary>
		/// An interaction shown when you're accepting a new quest.
		/// </summary>
		QuestAccept = 6,

		/// <summary>
		/// Honestly, this doesn't seem consistent to me. It is used to give you choices in the Cryptarch as well as some reward prompts by the Eververse vendor. I'll have to look into that further at some point.
		/// </summary>
		ProgressTab = 7,

		/// <summary>
		/// These seem even less consistent. I don't know what these are.
		/// </summary>
		End = 8,

		/// <summary>
		/// Also seem inconsistent. I also don't know what these are offhand.
		/// </summary>
		Start = 9
	}
}

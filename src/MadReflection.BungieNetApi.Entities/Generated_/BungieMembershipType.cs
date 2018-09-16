﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;

namespace BungieNet
{
	/// <summary>
	/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
	/// </summary>
	public enum BungieMembershipType
	{
		None = 0,

		TigerXbox = 1,

		TigerPsn = 2,

		TigerBlizzard = 4,

		TigerDemon = 10,

		BungieNext = 254,

		/// <summary>
		/// "All" is only valid for searching capabilities: you need to pass the actual matching BungieMembershipType for any query where you pass a known membershipId.
		/// </summary>
		All = -1
	}
}
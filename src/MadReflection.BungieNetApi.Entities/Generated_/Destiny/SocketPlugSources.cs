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
	/// Indicates how a socket is populated, and where you should look for valid plug data. This is a flags enumeration/bitmask field, as you may have to look in multiple sources across multiple components for valid plugs.
	/// </summary>
	[Flags]
	public enum SocketPlugSources
	{
		/// <summary>
		/// If there's no way we can detect to insert new plugs.
		/// </summary>
		None = 0x0,

		/// <summary>
		/// Use plugs found in the player's inventory, based on the socket type rules (see DestinySocketTypeDefinition for more info)
		/// Note that a socket - like Shaders - can have *both* reusable plugs and inventory items inserted theoretically.
		/// </summary>
		InventorySourced = 0x1,

		/// <summary>
		/// Use the DestinyItemSocketsComponent.sockets.reusablePlugs property to determine which plugs are valid for this socket.
		/// </summary>
		ReusablePlugItems = 0x2,

		/// <summary>
		/// Use the ProfilePlugSets component data to determine which plugs are valid for this socket.
		/// </summary>
		ProfilePlugSet = 0x4,

		/// <summary>
		/// Use the CharacterPlugSets component data to determine which plugs are valid for this socket.
		/// </summary>
		CharacterPlugSet = 0x8
	}
}

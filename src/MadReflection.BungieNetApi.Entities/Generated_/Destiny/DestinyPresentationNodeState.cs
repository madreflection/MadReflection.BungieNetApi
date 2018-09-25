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
	/// I know this doesn't look like a Flags Enumeration right now, but I assure you it is. This is the possible states that a Presentation Node can be in, and it is almost certain that its potential states will increase in the future. So don't treat it like a straight up enumeration.
	/// </summary>
	public enum DestinyPresentationNodeState
	{
		None = 0,

		/// <summary>
		/// If this is set, the game recommends that you not show this node. But you know your life, do what you've got to do.
		/// </summary>
		Invisible = 1,

		/// <summary>
		/// Turns out Presentation Nodes can also be obscured. If they are, this is set.
		/// </summary>
		Obscured = 2
	}
}

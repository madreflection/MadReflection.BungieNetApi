﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Sockets
{
	/// <summary>
	/// Data related to what happens while a plug is being inserted, mostly for UI purposes.
	/// </summary>
	public partial class DestinyInsertPlugActionDefinition
	{
		[JsonProperty("actionExecuteSeconds")]
		public int ActionExecuteSeconds { get; set; }

		[JsonProperty("actionType")]
		public Destiny.SocketTypeActionType ActionType { get; set; }
	}
}

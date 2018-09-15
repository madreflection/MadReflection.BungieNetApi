﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Entities.Items
{
	/// <summary>
	/// Instanced items can have sockets, which are slots on the item where plugs can be inserted.
	/// Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition's "socket" block and elsewhere on these objects for more details.
	/// </summary>
	public partial class DestinyItemSocketsComponent
	{
		[JsonProperty("sockets")]
		public Destiny.Entities.Items.DestinyItemSocketState[] Sockets { get; set; }
	}
}

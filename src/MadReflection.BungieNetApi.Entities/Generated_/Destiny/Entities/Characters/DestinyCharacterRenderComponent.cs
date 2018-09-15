﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Entities.Characters
{
	/// <summary>
	/// Only really useful if you're attempting to render the character's current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you'll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.
	/// Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.
	/// </summary>
	public partial class DestinyCharacterRenderComponent
	{
		[JsonProperty("customDyes")]
		public Destiny.DyeReference[] CustomDyes { get; set; }

		[JsonProperty("customization")]
		public Destiny.Character.DestinyCharacterCustomization Customization { get; set; }

		[JsonProperty("peerView")]
		public Destiny.Character.DestinyCharacterPeerView PeerView { get; set; }
	}
}

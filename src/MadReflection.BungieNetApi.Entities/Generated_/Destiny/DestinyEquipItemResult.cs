﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny
{
	/// <summary>
	/// The results of an Equipping operation performed through the Destiny API.
	/// </summary>
	public partial class DestinyEquipItemResult
	{
		[JsonProperty("itemInstanceId")]
		public long ItemInstanceId { get; set; }

		[JsonProperty("equipStatus")]
		public Exceptions.PlatformErrorCodes EquipStatus { get; set; }
	}
}

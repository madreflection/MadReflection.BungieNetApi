﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// Not terribly useful, some basic cooldown interaction info.
	/// </summary>
	public partial class DestinyVendorSaleItemActionBlockDefinition
	{
		[JsonProperty("executeSeconds")]
		public float ExecuteSeconds { get; set; }

		[JsonProperty("isPositive")]
		public bool IsPositive { get; set; }
	}
}
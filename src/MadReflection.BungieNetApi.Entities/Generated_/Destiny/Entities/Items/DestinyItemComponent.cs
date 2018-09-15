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
	/// The base item component, filled with properties that are generally useful to know in any item request or that don't feel worthwhile to put in their own component.
	/// </summary>
	public partial class DestinyItemComponent
	{
		[JsonProperty("itemHash")]
		public uint ItemHash { get; set; }

		[JsonProperty("itemInstanceId")]
		public long? ItemInstanceId { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("bindStatus")]
		public Destiny.ItemBindStatus BindStatus { get; set; }

		[JsonProperty("location")]
		public Destiny.ItemLocation Location { get; set; }

		[JsonProperty("bucketHash")]
		public uint BucketHash { get; set; }

		[JsonProperty("transferStatus")]
		public Destiny.TransferStatuses TransferStatus { get; set; }

		[JsonProperty("lockable")]
		public bool Lockable { get; set; }

		[JsonProperty("state")]
		public Destiny.ItemState State { get; set; }

		[JsonProperty("overrideStyleItemHash")]
		public uint? OverrideStyleItemHash { get; set; }
	}
}

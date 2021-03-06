﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// If you ever wondered how the Vault works, here it is.
	/// The Vault is merely a set of inventory buckets that exist on your Profile/Account level. When you transfer items in the Vault, the game is using the Vault Vendor's DestinyVendorAcceptedItemDefinitions to see where the appropriate destination bucket is for the source bucket from whence your item is moving. If it finds such an entry, it transfers the item to the other bucket.
	/// The mechanics for Postmaster works similarly, which is also a vendor. All driven by Accepted Items.
	/// </summary>
	public partial class DestinyVendorAcceptedItemDefinition
	{
		[JsonProperty("acceptedInventoryBucketHash")]
		public uint AcceptedInventoryBucketHash { get; set; }

		[JsonProperty("destinationInventoryBucketHash")]
		public uint DestinationInventoryBucketHash { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyInventoryItemDefinition
	{
		[Undocumented]
		[JsonProperty("acquireRewardSiteHash")]
		public uint AcquireRewardSiteHash { get; set; }

		[Undocumented]
		[JsonProperty("acquireUnlockHash")]
		public uint AcquireUnlockHash { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyVendorDefinition
	{
		[Undocumented("This property appears to be missing from both the OpenAPI schema and the documentation yet VendorSubcategoryIdentifier is not.")]
		[JsonProperty("vendorCategoryIdentifier")]
		public string VendorCategoryIdentifier { get; set; }

		[Undocumented]
		[JsonProperty("unlockValueHash")]
		public long UnlockValueHash { get; set; }
	}
}

﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Common.Models
{
	public partial class CoreSetting
	{
		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("isDefault")]
		public bool IsDefault { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("imagePath")]
		public string ImagePath { get; set; }

		[JsonProperty("childSettings")]
		public Common.Models.CoreSetting[] ChildSettings { get; set; }
	}
}
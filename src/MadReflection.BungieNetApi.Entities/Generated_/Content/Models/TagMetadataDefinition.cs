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

namespace BungieNet.Content.Models
{
	public partial class TagMetadataDefinition
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("order")]
		public int Order { get; set; }

		[JsonProperty("items")]
		public Content.Models.TagMetadataItem[] Items { get; set; }

		[JsonProperty("datatype")]
		public string Datatype { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("isRequired")]
		public bool IsRequired { get; set; }
	}
}

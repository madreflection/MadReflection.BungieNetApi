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
	/// The details of an overlay prompt to show to a user. They are all fairly self-explanatory localized strings that can be shown.
	/// </summary>
	public partial class DestinyVendorCategoryOverlayDefinition
	{
		[JsonProperty("choiceDescription")]
		public string ChoiceDescription { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("currencyItemHash")]
		public uint? CurrencyItemHash { get; set; }
	}
}

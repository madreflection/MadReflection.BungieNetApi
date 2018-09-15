﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Responses
{
	/// <summary>
	/// The response for GetDestinyProfile, with components for character and item-level data.
	/// </summary>
	public partial class DestinyProfileResponse
	{
		[JsonProperty("vendorReceipts")]
		public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }

		[JsonProperty("profileInventory")]
		public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; }

		[JsonProperty("profileCurrencies")]
		public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; }

		[JsonProperty("profile")]
		public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; }

		[JsonProperty("profileKiosks")]
		public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; }

		[JsonProperty("profilePlugSets")]
		public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; set; }

		[JsonProperty("profileProgression")]
		public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; set; }

		[JsonProperty("characters")]
		public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; }

		[JsonProperty("characterInventories")]
		public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; set; }

		[JsonProperty("characterProgressions")]
		public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; set; }

		[JsonProperty("characterRenderData")]
		public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; set; }

		[JsonProperty("characterActivities")]
		public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; set; }

		[JsonProperty("characterEquipment")]
		public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; }

		[JsonProperty("characterKiosks")]
		public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; set; }

		[JsonProperty("characterPlugSets")]
		public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets { get; set; }

		[JsonProperty("characterUninstancedItemComponents")]
		public System.Collections.Generic.Dictionary<long, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents { get; set; }

		[JsonProperty("itemComponents")]
		public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

		[JsonProperty("characterCurrencyLookups")]
		public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups { get; set; }
	}
}

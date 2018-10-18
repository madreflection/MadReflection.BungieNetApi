namespace BungieNet.Destiny
{
	public static class DestinyComponentTypes
	{
		/// <summary>
		/// All components.  Combination of: Profiles, VendorReceipts, ProfileInventories,
		/// ProfileCurrencies, Characters, CharacterInventories, CharacterProgressions,
		/// CharacterRenderData, CharacterActivities, CharacterEquipment, ItemInstances,
		/// ItemObjectives, ItemPerks, ItemRenderData, ItemStats, ItemSockets, ItemTalentGrids,
		/// ItemCommonData, ItemPlugStates, Vendors, VendorCategories, VendorSales, and Kiosks
		/// </summary>
		public static readonly DestinyComponentType[] All = new DestinyComponentType[]
			{
				DestinyComponentType.Profiles,
				DestinyComponentType.VendorReceipts,
				DestinyComponentType.ProfileInventories,
				DestinyComponentType.ProfileCurrencies,
				DestinyComponentType.Characters,
				DestinyComponentType.CharacterInventories,
				DestinyComponentType.CharacterProgressions,
				DestinyComponentType.CharacterRenderData,
				DestinyComponentType.CharacterActivities,
				DestinyComponentType.CharacterEquipment,
				DestinyComponentType.ItemInstances,
				DestinyComponentType.ItemObjectives,
				DestinyComponentType.ItemPerks,
				DestinyComponentType.ItemRenderData,
				DestinyComponentType.ItemStats,
				DestinyComponentType.ItemSockets,
				DestinyComponentType.ItemTalentGrids,
				DestinyComponentType.ItemCommonData,
				DestinyComponentType.ItemPlugStates,
				DestinyComponentType.Vendors,
				DestinyComponentType.VendorCategories,
				DestinyComponentType.VendorSales,
				DestinyComponentType.Kiosks
			};

		/// <summary>
		/// Profile-related components.  Combination of: Profiles, VendorReceipts, ProfileInventories,
		/// ProfileCurrencies, Characters, CharacterInventories, CharacterProgressions,
		/// CharacterRenderData, CharacterActivities, CharacterEquipment, and Kiosks
		/// </summary>
		public static readonly DestinyComponentType[] Profile = new DestinyComponentType[]
			{
				DestinyComponentType.Profiles,
				DestinyComponentType.VendorReceipts,
				DestinyComponentType.ProfileInventories,
				DestinyComponentType.ProfileCurrencies,
				DestinyComponentType.Characters,
				DestinyComponentType.CharacterInventories,
				DestinyComponentType.CharacterProgressions,
				DestinyComponentType.CharacterRenderData,
				DestinyComponentType.CharacterActivities,
				DestinyComponentType.CharacterEquipment,
				DestinyComponentType.Kiosks
			};

		/// <summary>
		/// Character-related components.  Combination of: Characters, CharacterInventories,
		/// CharacterProgressions, CharacterActivities, CharacterEquipment, and Kiosks
		/// </summary>
		public static readonly DestinyComponentType[] Character = new DestinyComponentType[]
			{
				DestinyComponentType.Characters,
				DestinyComponentType.CharacterInventories,
				DestinyComponentType.CharacterProgressions,
				DestinyComponentType.CharacterActivities,
				DestinyComponentType.CharacterEquipment,
				DestinyComponentType.Kiosks
			};
	}
}

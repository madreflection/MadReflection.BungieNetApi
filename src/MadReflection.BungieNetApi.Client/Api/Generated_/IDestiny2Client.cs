﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BungieNet.Api
{
	public interface IDestiny2Client
	{
		Destiny.Config.DestinyManifest GetDestinyManifest();
		Task<Destiny.Config.DestinyManifest> GetDestinyManifestAsync();

		Destiny.Definitions.DestinyDefinition GetDestinyEntityDefinition(string entityType, uint hashIdentifier);
		Task<Destiny.Definitions.DestinyDefinition> GetDestinyEntityDefinitionAsync(string entityType, uint hashIdentifier);

		User.UserInfoCard[] SearchDestinyPlayer(BungieMembershipType membershipType, string displayName);
		Task<User.UserInfoCard[]> SearchDestinyPlayerAsync(BungieMembershipType membershipType, string displayName);

		Destiny.Responses.DestinyLinkedProfilesResponse GetLinkedProfiles(BungieMembershipType membershipType, long membershipId);
		Task<Destiny.Responses.DestinyLinkedProfilesResponse> GetLinkedProfilesAsync(BungieMembershipType membershipType, long membershipId);

		Destiny.Responses.DestinyProfileResponse GetProfile(BungieMembershipType membershipType, long destinyMembershipId, Destiny.DestinyComponentType[] components);
		Task<Destiny.Responses.DestinyProfileResponse> GetProfileAsync(BungieMembershipType membershipType, long destinyMembershipId, Destiny.DestinyComponentType[] components);

		Destiny.Responses.DestinyCharacterResponse GetCharacter(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components);
		Task<Destiny.Responses.DestinyCharacterResponse> GetCharacterAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components);

		Destiny.Milestones.DestinyMilestone GetClanWeeklyRewardState(long groupId);
		Task<Destiny.Milestones.DestinyMilestone> GetClanWeeklyRewardStateAsync(long groupId);

		Destiny.Responses.DestinyItemResponse GetItem(BungieMembershipType membershipType, long destinyMembershipId, long itemInstanceId, Destiny.DestinyComponentType[] components);
		Task<Destiny.Responses.DestinyItemResponse> GetItemAsync(BungieMembershipType membershipType, long destinyMembershipId, long itemInstanceId, Destiny.DestinyComponentType[] components);

		Destiny.Responses.DestinyVendorsResponse GetVendors(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components);
		Task<Destiny.Responses.DestinyVendorsResponse> GetVendorsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components);

		Destiny.Responses.DestinyVendorResponse GetVendor(BungieMembershipType membershipType, long destinyMembershipId, long characterId, uint vendorHash, Destiny.DestinyComponentType[] components);
		Task<Destiny.Responses.DestinyVendorResponse> GetVendorAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, uint vendorHash, Destiny.DestinyComponentType[] components);

		int TransferItem();
		Task<int> TransferItemAsync();

		int PullFromPostmaster();
		Task<int> PullFromPostmasterAsync();

		int EquipItem();
		Task<int> EquipItemAsync();

		Destiny.DestinyEquipItemResults EquipItems();
		Task<Destiny.DestinyEquipItemResults> EquipItemsAsync();

		int SetItemLockState();
		Task<int> SetItemLockStateAsync();

		Destiny.Responses.DestinyItemChangeResponse InsertSocketPlug();
		Task<Destiny.Responses.DestinyItemChangeResponse> InsertSocketPlugAsync();

		Destiny.HistoricalStats.DestinyPostGameCarnageReportData GetPostGameCarnageReport(long activityId);
		Task<Destiny.HistoricalStats.DestinyPostGameCarnageReportData> GetPostGameCarnageReportAsync(long activityId);

		int ReportOffensivePostGameCarnageReportPlayer(long activityId);
		Task<int> ReportOffensivePostGameCarnageReportPlayerAsync(long activityId);

		System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.Definitions.DestinyHistoricalStatsDefinition> GetHistoricalStatsDefinition();
		Task<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.Definitions.DestinyHistoricalStatsDefinition>> GetHistoricalStatsDefinitionAsync();

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> GetClanLeaderboards(long groupId, int maxtop, string modes, string statid);
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> GetClanLeaderboardsAsync(long groupId, int maxtop, string modes, string statid);

		Destiny.HistoricalStats.DestinyClanAggregateStat[] GetClanAggregateStats(long groupId, string modes);
		Task<Destiny.HistoricalStats.DestinyClanAggregateStat[]> GetClanAggregateStatsAsync(long groupId, string modes);

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> GetLeaderboards(BungieMembershipType membershipType, long destinyMembershipId, int maxtop, string modes, string statid);
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> GetLeaderboardsAsync(BungieMembershipType membershipType, long destinyMembershipId, int maxtop, string modes, string statid);

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> GetLeaderboardsForCharacter(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int maxtop, string modes, string statid);
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> GetLeaderboardsForCharacterAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int maxtop, string modes, string statid);

		Destiny.Definitions.DestinyEntitySearchResult SearchDestinyEntities(string type, string searchTerm, int page);
		Task<Destiny.Definitions.DestinyEntitySearchResult> SearchDestinyEntitiesAsync(string type, string searchTerm, int page);

		System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod> GetHistoricalStats(BungieMembershipType membershipType, long destinyMembershipId, long characterId, DateTime dayend, DateTime daystart, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups, Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] modes, Destiny.HistoricalStats.Definitions.PeriodType periodType);
		Task<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod>> GetHistoricalStatsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, DateTime dayend, DateTime daystart, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups, Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] modes, Destiny.HistoricalStats.Definitions.PeriodType periodType);

		Destiny.HistoricalStats.DestinyHistoricalStatsAccountResult GetHistoricalStatsForAccount(BungieMembershipType membershipType, long destinyMembershipId, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups);
		Task<Destiny.HistoricalStats.DestinyHistoricalStatsAccountResult> GetHistoricalStatsForAccountAsync(BungieMembershipType membershipType, long destinyMembershipId, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups);

		Destiny.HistoricalStats.DestinyActivityHistoryResults GetActivityHistory(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int count, Destiny.HistoricalStats.Definitions.DestinyActivityModeType mode, int page);
		Task<Destiny.HistoricalStats.DestinyActivityHistoryResults> GetActivityHistoryAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int count, Destiny.HistoricalStats.Definitions.DestinyActivityModeType mode, int page);

		Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData GetUniqueWeaponHistory(BungieMembershipType membershipType, long destinyMembershipId, long characterId);
		Task<Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData> GetUniqueWeaponHistoryAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId);

		Destiny.HistoricalStats.DestinyAggregateActivityResults GetDestinyAggregateActivityStats(BungieMembershipType membershipType, long destinyMembershipId, long characterId);
		Task<Destiny.HistoricalStats.DestinyAggregateActivityResults> GetDestinyAggregateActivityStatsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId);

		Destiny.Milestones.DestinyMilestoneContent GetPublicMilestoneContent(uint milestoneHash);
		Task<Destiny.Milestones.DestinyMilestoneContent> GetPublicMilestoneContentAsync(uint milestoneHash);

		System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyPublicMilestone> GetPublicMilestones();
		Task<System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyPublicMilestone>> GetPublicMilestonesAsync();

		Destiny.Advanced.AwaInitializeResponse AwaInitializeRequest();
		Task<Destiny.Advanced.AwaInitializeResponse> AwaInitializeRequestAsync();

		int AwaProvideAuthorizationResult();
		Task<int> AwaProvideAuthorizationResultAsync();

		Destiny.Advanced.AwaAuthorizationResult AwaGetActionToken(string correlationId);
		Task<Destiny.Advanced.AwaAuthorizationResult> AwaGetActionTokenAsync(string correlationId);
	}

	partial class BungieClient : IDestiny2Client
	{
		public IDestiny2Client Destiny2 => this;


		Destiny.Config.DestinyManifest IDestiny2Client.GetDestinyManifest() => Destiny2.GetDestinyManifestAsync().GetAwaiter().GetResult();
		Task<Destiny.Config.DestinyManifest> IDestiny2Client.GetDestinyManifestAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Manifest" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Config.DestinyManifest>(uri);
		}

		Destiny.Definitions.DestinyDefinition IDestiny2Client.GetDestinyEntityDefinition(string entityType, uint hashIdentifier) => Destiny2.GetDestinyEntityDefinitionAsync(entityType, hashIdentifier).GetAwaiter().GetResult();
		Task<Destiny.Definitions.DestinyDefinition> IDestiny2Client.GetDestinyEntityDefinitionAsync(string entityType, uint hashIdentifier)
		{
			if (entityType is null)
				throw new ArgumentNullException(nameof(entityType));
			string[] pathSegments = new string[] { "Destiny2", "Manifest", entityType, hashIdentifier.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Definitions.DestinyDefinition>(uri);
		}

		User.UserInfoCard[] IDestiny2Client.SearchDestinyPlayer(BungieMembershipType membershipType, string displayName) => Destiny2.SearchDestinyPlayerAsync(membershipType, displayName).GetAwaiter().GetResult();
		Task<User.UserInfoCard[]> IDestiny2Client.SearchDestinyPlayerAsync(BungieMembershipType membershipType, string displayName)
		{
			if (displayName is null)
				throw new ArgumentNullException(nameof(displayName));
			string[] pathSegments = new string[] { "Destiny2", "SearchDestinyPlayer", ((int)membershipType).ToString(), displayName };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityArrayAsync<User.UserInfoCard>(uri);
		}

		Destiny.Responses.DestinyLinkedProfilesResponse IDestiny2Client.GetLinkedProfiles(BungieMembershipType membershipType, long membershipId) => Destiny2.GetLinkedProfilesAsync(membershipType, membershipId).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyLinkedProfilesResponse> IDestiny2Client.GetLinkedProfilesAsync(BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", membershipId.ToString(), "LinkedProfiles" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Responses.DestinyLinkedProfilesResponse>(uri);
		}

		Destiny.Responses.DestinyProfileResponse IDestiny2Client.GetProfile(BungieMembershipType membershipType, long destinyMembershipId, Destiny.DestinyComponentType[] components) => Destiny2.GetProfileAsync(membershipType, destinyMembershipId, components).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyProfileResponse> IDestiny2Client.GetProfileAsync(BungieMembershipType membershipType, long destinyMembershipId, Destiny.DestinyComponentType[] components)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", destinyMembershipId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("components", string.Join(",", components))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Responses.DestinyProfileResponse>(uri);
		}

		Destiny.Responses.DestinyCharacterResponse IDestiny2Client.GetCharacter(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components) => Destiny2.GetCharacterAsync(membershipType, destinyMembershipId, characterId, components).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyCharacterResponse> IDestiny2Client.GetCharacterAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", destinyMembershipId.ToString(), "Character", characterId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("components", string.Join(",", components))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Responses.DestinyCharacterResponse>(uri);
		}

		Destiny.Milestones.DestinyMilestone IDestiny2Client.GetClanWeeklyRewardState(long groupId) => Destiny2.GetClanWeeklyRewardStateAsync(groupId).GetAwaiter().GetResult();
		Task<Destiny.Milestones.DestinyMilestone> IDestiny2Client.GetClanWeeklyRewardStateAsync(long groupId)
		{
			string[] pathSegments = new string[] { "Destiny2", "Clan", groupId.ToString(), "WeeklyRewardState" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Milestones.DestinyMilestone>(uri);
		}

		Destiny.Responses.DestinyItemResponse IDestiny2Client.GetItem(BungieMembershipType membershipType, long destinyMembershipId, long itemInstanceId, Destiny.DestinyComponentType[] components) => Destiny2.GetItemAsync(membershipType, destinyMembershipId, itemInstanceId, components).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyItemResponse> IDestiny2Client.GetItemAsync(BungieMembershipType membershipType, long destinyMembershipId, long itemInstanceId, Destiny.DestinyComponentType[] components)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", destinyMembershipId.ToString(), "Item", itemInstanceId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("components", string.Join(",", components))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Responses.DestinyItemResponse>(uri);
		}

		Destiny.Responses.DestinyVendorsResponse IDestiny2Client.GetVendors(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components) => Destiny2.GetVendorsAsync(membershipType, destinyMembershipId, characterId, components).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyVendorsResponse> IDestiny2Client.GetVendorsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, Destiny.DestinyComponentType[] components)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Vendors" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("components", string.Join(",", components))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Responses.DestinyVendorsResponse>(uri);
		}

		Destiny.Responses.DestinyVendorResponse IDestiny2Client.GetVendor(BungieMembershipType membershipType, long destinyMembershipId, long characterId, uint vendorHash, Destiny.DestinyComponentType[] components) => Destiny2.GetVendorAsync(membershipType, destinyMembershipId, characterId, vendorHash, components).GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyVendorResponse> IDestiny2Client.GetVendorAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, uint vendorHash, Destiny.DestinyComponentType[] components)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Profile", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Vendors", vendorHash.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("components", string.Join(",", components))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Responses.DestinyVendorResponse>(uri);
		}

		int IDestiny2Client.TransferItem() => Destiny2.TransferItemAsync().GetAwaiter().GetResult();
		Task<int> IDestiny2Client.TransferItemAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "TransferItem" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		int IDestiny2Client.PullFromPostmaster() => Destiny2.PullFromPostmasterAsync().GetAwaiter().GetResult();
		Task<int> IDestiny2Client.PullFromPostmasterAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "PullFromPostmaster" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		int IDestiny2Client.EquipItem() => Destiny2.EquipItemAsync().GetAwaiter().GetResult();
		Task<int> IDestiny2Client.EquipItemAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "EquipItem" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		Destiny.DestinyEquipItemResults IDestiny2Client.EquipItems() => Destiny2.EquipItemsAsync().GetAwaiter().GetResult();
		Task<Destiny.DestinyEquipItemResults> IDestiny2Client.EquipItemsAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "EquipItems" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Destiny.DestinyEquipItemResults>(uri);
		}

		int IDestiny2Client.SetItemLockState() => Destiny2.SetItemLockStateAsync().GetAwaiter().GetResult();
		Task<int> IDestiny2Client.SetItemLockStateAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "SetLockState" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		Destiny.Responses.DestinyItemChangeResponse IDestiny2Client.InsertSocketPlug() => Destiny2.InsertSocketPlugAsync().GetAwaiter().GetResult();
		Task<Destiny.Responses.DestinyItemChangeResponse> IDestiny2Client.InsertSocketPlugAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Actions", "Items", "InsertSocketPlug" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Destiny.Responses.DestinyItemChangeResponse>(uri);
		}

		Destiny.HistoricalStats.DestinyPostGameCarnageReportData IDestiny2Client.GetPostGameCarnageReport(long activityId) => Destiny2.GetPostGameCarnageReportAsync(activityId).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyPostGameCarnageReportData> IDestiny2Client.GetPostGameCarnageReportAsync(long activityId)
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "PostGameCarnageReport", activityId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.HistoricalStats.DestinyPostGameCarnageReportData>(uri);
		}

		int IDestiny2Client.ReportOffensivePostGameCarnageReportPlayer(long activityId) => Destiny2.ReportOffensivePostGameCarnageReportPlayerAsync(activityId).GetAwaiter().GetResult();
		Task<int> IDestiny2Client.ReportOffensivePostGameCarnageReportPlayerAsync(long activityId)
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "PostGameCarnageReport", activityId.ToString(), "Report" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.Definitions.DestinyHistoricalStatsDefinition> IDestiny2Client.GetHistoricalStatsDefinition() => Destiny2.GetHistoricalStatsDefinitionAsync().GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.Definitions.DestinyHistoricalStatsDefinition>> IDestiny2Client.GetHistoricalStatsDefinitionAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "Definition" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.Definitions.DestinyHistoricalStatsDefinition>>(uri);
		}

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> IDestiny2Client.GetClanLeaderboards(long groupId, int maxtop, string modes, string statid) => Destiny2.GetClanLeaderboardsAsync(groupId, maxtop, modes, statid).GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> IDestiny2Client.GetClanLeaderboardsAsync(long groupId, int maxtop, string modes, string statid)
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "Leaderboards", "Clans", groupId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("maxtop", maxtop.ToString()),
				new QueryStringItem("modes", (modes ?? "")),
				new QueryStringItem("statid", (statid ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>>(uri);
		}

		Destiny.HistoricalStats.DestinyClanAggregateStat[] IDestiny2Client.GetClanAggregateStats(long groupId, string modes) => Destiny2.GetClanAggregateStatsAsync(groupId, modes).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyClanAggregateStat[]> IDestiny2Client.GetClanAggregateStatsAsync(long groupId, string modes)
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "AggregateClanStats", groupId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("modes", (modes ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityArrayAsync<Destiny.HistoricalStats.DestinyClanAggregateStat>(uri);
		}

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> IDestiny2Client.GetLeaderboards(BungieMembershipType membershipType, long destinyMembershipId, int maxtop, string modes, string statid) => Destiny2.GetLeaderboardsAsync(membershipType, destinyMembershipId, maxtop, modes, statid).GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> IDestiny2Client.GetLeaderboardsAsync(BungieMembershipType membershipType, long destinyMembershipId, int maxtop, string modes, string statid)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Stats", "Leaderboards" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("maxtop", maxtop.ToString()),
				new QueryStringItem("modes", (modes ?? "")),
				new QueryStringItem("statid", (statid ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>>(uri);
		}

		System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>> IDestiny2Client.GetLeaderboardsForCharacter(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int maxtop, string modes, string statid) => Destiny2.GetLeaderboardsForCharacterAsync(membershipType, destinyMembershipId, characterId, maxtop, modes, statid).GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>> IDestiny2Client.GetLeaderboardsForCharacterAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int maxtop, string modes, string statid)
		{
			string[] pathSegments = new string[] { "Destiny2", "Stats", "Leaderboards", ((int)membershipType).ToString(), destinyMembershipId.ToString(), characterId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("maxtop", maxtop.ToString()),
				new QueryStringItem("modes", (modes ?? "")),
				new QueryStringItem("statid", (statid ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyLeaderboard>>>(uri);
		}

		Destiny.Definitions.DestinyEntitySearchResult IDestiny2Client.SearchDestinyEntities(string type, string searchTerm, int page) => Destiny2.SearchDestinyEntitiesAsync(type, searchTerm, page).GetAwaiter().GetResult();
		Task<Destiny.Definitions.DestinyEntitySearchResult> IDestiny2Client.SearchDestinyEntitiesAsync(string type, string searchTerm, int page)
		{
			if (type is null)
				throw new ArgumentNullException(nameof(type));
			if (searchTerm is null)
				throw new ArgumentNullException(nameof(searchTerm));
			string[] pathSegments = new string[] { "Destiny2", "Armory", "Search", type, searchTerm };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("page", page.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.Definitions.DestinyEntitySearchResult>(uri);
		}

		System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod> IDestiny2Client.GetHistoricalStats(BungieMembershipType membershipType, long destinyMembershipId, long characterId, DateTime dayend, DateTime daystart, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups, Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] modes, Destiny.HistoricalStats.Definitions.PeriodType periodType) => Destiny2.GetHistoricalStatsAsync(membershipType, destinyMembershipId, characterId, dayend, daystart, groups, modes, periodType).GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod>> IDestiny2Client.GetHistoricalStatsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, DateTime dayend, DateTime daystart, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups, Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] modes, Destiny.HistoricalStats.Definitions.PeriodType periodType)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Stats" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("dayend", dayend.ToString()),
				new QueryStringItem("daystart", daystart.ToString()),
				new QueryStringItem("groups", string.Join(",", groups)),
				new QueryStringItem("modes", string.Join(",", modes)),
				new QueryStringItem("periodType", ((int)periodType).ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod>>(uri);
		}

		Destiny.HistoricalStats.DestinyHistoricalStatsAccountResult IDestiny2Client.GetHistoricalStatsForAccount(BungieMembershipType membershipType, long destinyMembershipId, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups) => Destiny2.GetHistoricalStatsForAccountAsync(membershipType, destinyMembershipId, groups).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyHistoricalStatsAccountResult> IDestiny2Client.GetHistoricalStatsForAccountAsync(BungieMembershipType membershipType, long destinyMembershipId, Destiny.HistoricalStats.Definitions.DestinyStatsGroupType[] groups)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Stats" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("groups", string.Join(",", groups))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.HistoricalStats.DestinyHistoricalStatsAccountResult>(uri);
		}

		Destiny.HistoricalStats.DestinyActivityHistoryResults IDestiny2Client.GetActivityHistory(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int count, Destiny.HistoricalStats.Definitions.DestinyActivityModeType mode, int page) => Destiny2.GetActivityHistoryAsync(membershipType, destinyMembershipId, characterId, count, mode, page).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyActivityHistoryResults> IDestiny2Client.GetActivityHistoryAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId, int count, Destiny.HistoricalStats.Definitions.DestinyActivityModeType mode, int page)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Stats", "Activities" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("count", count.ToString()),
				new QueryStringItem("mode", ((int)mode).ToString()),
				new QueryStringItem("page", page.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Destiny.HistoricalStats.DestinyActivityHistoryResults>(uri);
		}

		Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData IDestiny2Client.GetUniqueWeaponHistory(BungieMembershipType membershipType, long destinyMembershipId, long characterId) => Destiny2.GetUniqueWeaponHistoryAsync(membershipType, destinyMembershipId, characterId).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData> IDestiny2Client.GetUniqueWeaponHistoryAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Stats", "UniqueWeapons" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData>(uri);
		}

		Destiny.HistoricalStats.DestinyAggregateActivityResults IDestiny2Client.GetDestinyAggregateActivityStats(BungieMembershipType membershipType, long destinyMembershipId, long characterId) => Destiny2.GetDestinyAggregateActivityStatsAsync(membershipType, destinyMembershipId, characterId).GetAwaiter().GetResult();
		Task<Destiny.HistoricalStats.DestinyAggregateActivityResults> IDestiny2Client.GetDestinyAggregateActivityStatsAsync(BungieMembershipType membershipType, long destinyMembershipId, long characterId)
		{
			string[] pathSegments = new string[] { "Destiny2", ((int)membershipType).ToString(), "Account", destinyMembershipId.ToString(), "Character", characterId.ToString(), "Stats", "AggregateActivityStats" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.HistoricalStats.DestinyAggregateActivityResults>(uri);
		}

		Destiny.Milestones.DestinyMilestoneContent IDestiny2Client.GetPublicMilestoneContent(uint milestoneHash) => Destiny2.GetPublicMilestoneContentAsync(milestoneHash).GetAwaiter().GetResult();
		Task<Destiny.Milestones.DestinyMilestoneContent> IDestiny2Client.GetPublicMilestoneContentAsync(uint milestoneHash)
		{
			string[] pathSegments = new string[] { "Destiny2", "Milestones", milestoneHash.ToString(), "Content" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Milestones.DestinyMilestoneContent>(uri);
		}

		System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyPublicMilestone> IDestiny2Client.GetPublicMilestones() => Destiny2.GetPublicMilestonesAsync().GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyPublicMilestone>> IDestiny2Client.GetPublicMilestonesAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Milestones" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<System.Collections.Generic.Dictionary<uint, Destiny.Milestones.DestinyPublicMilestone>>(uri);
		}

		Destiny.Advanced.AwaInitializeResponse IDestiny2Client.AwaInitializeRequest() => Destiny2.AwaInitializeRequestAsync().GetAwaiter().GetResult();
		Task<Destiny.Advanced.AwaInitializeResponse> IDestiny2Client.AwaInitializeRequestAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Awa", "Initialize" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Destiny.Advanced.AwaInitializeResponse>(uri);
		}

		int IDestiny2Client.AwaProvideAuthorizationResult() => Destiny2.AwaProvideAuthorizationResultAsync().GetAwaiter().GetResult();
		Task<int> IDestiny2Client.AwaProvideAuthorizationResultAsync()
		{
			string[] pathSegments = new string[] { "Destiny2", "Awa", "AwaProvideAuthorizationResult" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		Destiny.Advanced.AwaAuthorizationResult IDestiny2Client.AwaGetActionToken(string correlationId) => Destiny2.AwaGetActionTokenAsync(correlationId).GetAwaiter().GetResult();
		Task<Destiny.Advanced.AwaAuthorizationResult> IDestiny2Client.AwaGetActionTokenAsync(string correlationId)
		{
			if (correlationId is null)
				throw new ArgumentNullException(nameof(correlationId));
			string[] pathSegments = new string[] { "Destiny2", "Awa", "GetActionToken", correlationId };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Destiny.Advanced.AwaAuthorizationResult>(uri);
		}
	}
}

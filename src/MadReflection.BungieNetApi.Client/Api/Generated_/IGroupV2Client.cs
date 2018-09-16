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
	public interface IGroupV2Client
	{
		System.Collections.Generic.Dictionary<int, string> GetAvailableAvatars();
		Task<System.Collections.Generic.Dictionary<int, string>> GetAvailableAvatarsAsync();

		Config.GroupTheme[] GetAvailableThemes();
		Task<Config.GroupTheme[]> GetAvailableThemesAsync();

		bool GetUserClanInviteSetting(BungieMembershipType mType);
		Task<bool> GetUserClanInviteSettingAsync(BungieMembershipType mType);

		int SetUserClanInviteSetting(BungieMembershipType mType, bool allowInvites);
		Task<int> SetUserClanInviteSettingAsync(BungieMembershipType mType, bool allowInvites);

		GroupsV2.GroupV2Card[] GetRecommendedGroups(GroupsV2.GroupType groupType, GroupsV2.GroupDateRange createDateRange);
		Task<GroupsV2.GroupV2Card[]> GetRecommendedGroupsAsync(GroupsV2.GroupType groupType, GroupsV2.GroupDateRange createDateRange);

		GroupsV2.GroupSearchResponse GroupSearch();
		Task<GroupsV2.GroupSearchResponse> GroupSearchAsync();

		GroupsV2.GroupResponse GetGroup(long groupId);
		Task<GroupsV2.GroupResponse> GetGroupAsync(long groupId);

		GroupsV2.GroupResponse GetGroupByName(string groupName, GroupsV2.GroupType groupType);
		Task<GroupsV2.GroupResponse> GetGroupByNameAsync(string groupName, GroupsV2.GroupType groupType);

		GroupsV2.GroupOptionalConversation[] GetGroupOptionalConversations(long groupId);
		Task<GroupsV2.GroupOptionalConversation[]> GetGroupOptionalConversationsAsync(long groupId);

		GroupsV2.GroupCreationResponse CreateGroup();
		Task<GroupsV2.GroupCreationResponse> CreateGroupAsync();

		int EditGroup(long groupId);
		Task<int> EditGroupAsync(long groupId);

		int EditClanBanner(long groupId);
		Task<int> EditClanBannerAsync(long groupId);

		int EditFounderOptions(long groupId);
		Task<int> EditFounderOptionsAsync(long groupId);

		long AddOptionalConversation(long groupId);
		Task<long> AddOptionalConversationAsync(long groupId);

		long EditOptionalConversation(long groupId, long conversationId);
		Task<long> EditOptionalConversationAsync(long groupId, long conversationId);

		SearchResultOfGroupMember GetMembersOfGroup(long groupId, int currentpage, GroupsV2.RuntimeGroupMemberType memberType, string nameSearch);
		Task<SearchResultOfGroupMember> GetMembersOfGroupAsync(long groupId, int currentpage, GroupsV2.RuntimeGroupMemberType memberType, string nameSearch);

		SearchResultOfGroupMember GetAdminsAndFounderOfGroup(long groupId, int currentpage);
		Task<SearchResultOfGroupMember> GetAdminsAndFounderOfGroupAsync(long groupId, int currentpage);

		int EditGroupMembership(long groupId, BungieMembershipType membershipType, long membershipId, GroupsV2.RuntimeGroupMemberType memberType);
		Task<int> EditGroupMembershipAsync(long groupId, BungieMembershipType membershipType, long membershipId, GroupsV2.RuntimeGroupMemberType memberType);

		GroupsV2.GroupMemberLeaveResult KickMember(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<GroupsV2.GroupMemberLeaveResult> KickMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId);

		int BanMember(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<int> BanMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId);

		int UnbanMember(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<int> UnbanMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId);

		SearchResultOfGroupBan GetBannedMembersOfGroup(long groupId, int currentpage);
		Task<SearchResultOfGroupBan> GetBannedMembersOfGroupAsync(long groupId, int currentpage);

		bool AbdicateFoundership(long groupId, BungieMembershipType membershipType, long founderIdNew);
		Task<bool> AbdicateFoundershipAsync(long groupId, BungieMembershipType membershipType, long founderIdNew);

		GroupsV2.GroupApplicationResponse RequestGroupMembership(long groupId, BungieMembershipType membershipType);
		Task<GroupsV2.GroupApplicationResponse> RequestGroupMembershipAsync(long groupId, BungieMembershipType membershipType);

		SearchResultOfGroupMemberApplication GetPendingMemberships(long groupId, int currentpage);
		Task<SearchResultOfGroupMemberApplication> GetPendingMembershipsAsync(long groupId, int currentpage);

		SearchResultOfGroupMemberApplication GetInvitedIndividuals(long groupId, int currentpage);
		Task<SearchResultOfGroupMemberApplication> GetInvitedIndividualsAsync(long groupId, int currentpage);

		GroupsV2.GroupMemberLeaveResult RescindGroupMembership(long groupId, BungieMembershipType membershipType);
		Task<GroupsV2.GroupMemberLeaveResult> RescindGroupMembershipAsync(long groupId, BungieMembershipType membershipType);

		Entities.EntityActionResult[] ApproveAllPending(long groupId);
		Task<Entities.EntityActionResult[]> ApproveAllPendingAsync(long groupId);

		Entities.EntityActionResult[] DenyAllPending(long groupId);
		Task<Entities.EntityActionResult[]> DenyAllPendingAsync(long groupId);

		Entities.EntityActionResult[] ApprovePendingForList(long groupId);
		Task<Entities.EntityActionResult[]> ApprovePendingForListAsync(long groupId);

		bool ApprovePending(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<bool> ApprovePendingAsync(long groupId, BungieMembershipType membershipType, long membershipId);

		Entities.EntityActionResult[] DenyPendingForList(long groupId);
		Task<Entities.EntityActionResult[]> DenyPendingForListAsync(long groupId);

		GroupsV2.GroupMembershipSearchResponse GetGroupsForMember(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupsForMemberFilter filter, GroupsV2.GroupType groupType);
		Task<GroupsV2.GroupMembershipSearchResponse> GetGroupsForMemberAsync(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupsForMemberFilter filter, GroupsV2.GroupType groupType);

		GroupsV2.GroupPotentialMembershipSearchResponse GetPotentialGroupsForMember(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupPotentialMemberStatus filter, GroupsV2.GroupType groupType);
		Task<GroupsV2.GroupPotentialMembershipSearchResponse> GetPotentialGroupsForMemberAsync(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupPotentialMemberStatus filter, GroupsV2.GroupType groupType);

		GroupsV2.GroupApplicationResponse IndividualGroupInvite(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<GroupsV2.GroupApplicationResponse> IndividualGroupInviteAsync(long groupId, BungieMembershipType membershipType, long membershipId);

		GroupsV2.GroupApplicationResponse IndividualGroupInviteCancel(long groupId, BungieMembershipType membershipType, long membershipId);
		Task<GroupsV2.GroupApplicationResponse> IndividualGroupInviteCancelAsync(long groupId, BungieMembershipType membershipType, long membershipId);
	}

	partial class BungieClient : IGroupV2Client
	{
		public IGroupV2Client GroupV2 => this;


		System.Collections.Generic.Dictionary<int, string> IGroupV2Client.GetAvailableAvatars() => GroupV2.GetAvailableAvatarsAsync().GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<int, string>> IGroupV2Client.GetAvailableAvatarsAsync()
		{
			string[] pathSegments = new string[] { "GroupV2", "GetAvailableAvatars" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<System.Collections.Generic.Dictionary<int, string>>(uri);
		}

		Config.GroupTheme[] IGroupV2Client.GetAvailableThemes() => GroupV2.GetAvailableThemesAsync().GetAwaiter().GetResult();
		Task<Config.GroupTheme[]> IGroupV2Client.GetAvailableThemesAsync()
		{
			string[] pathSegments = new string[] { "GroupV2", "GetAvailableThemes" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityArrayAsync<Config.GroupTheme>(uri);
		}

		bool IGroupV2Client.GetUserClanInviteSetting(BungieMembershipType mType) => GroupV2.GetUserClanInviteSettingAsync(mType).GetAwaiter().GetResult();
		Task<bool> IGroupV2Client.GetUserClanInviteSettingAsync(BungieMembershipType mType)
		{
			string[] pathSegments = new string[] { "GroupV2", "GetUserClanInviteSetting", ((int)mType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<bool>(uri);
		}

		int IGroupV2Client.SetUserClanInviteSetting(BungieMembershipType mType, bool allowInvites) => GroupV2.SetUserClanInviteSettingAsync(mType, allowInvites).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.SetUserClanInviteSettingAsync(BungieMembershipType mType, bool allowInvites)
		{
			string[] pathSegments = new string[] { "GroupV2", "SetUserClanInviteSetting", ((int)mType).ToString(), allowInvites.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		GroupsV2.GroupV2Card[] IGroupV2Client.GetRecommendedGroups(GroupsV2.GroupType groupType, GroupsV2.GroupDateRange createDateRange) => GroupV2.GetRecommendedGroupsAsync(groupType, createDateRange).GetAwaiter().GetResult();
		Task<GroupsV2.GroupV2Card[]> IGroupV2Client.GetRecommendedGroupsAsync(GroupsV2.GroupType groupType, GroupsV2.GroupDateRange createDateRange)
		{
			string[] pathSegments = new string[] { "GroupV2", "Recommended", ((int)groupType).ToString(), ((int)createDateRange).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<GroupsV2.GroupV2Card>(uri);
		}

		GroupsV2.GroupSearchResponse IGroupV2Client.GroupSearch() => GroupV2.GroupSearchAsync().GetAwaiter().GetResult();
		Task<GroupsV2.GroupSearchResponse> IGroupV2Client.GroupSearchAsync()
		{
			string[] pathSegments = new string[] { "GroupV2", "Search" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupSearchResponse>(uri);
		}

		GroupsV2.GroupResponse IGroupV2Client.GetGroup(long groupId) => GroupV2.GetGroupAsync(groupId).GetAwaiter().GetResult();
		Task<GroupsV2.GroupResponse> IGroupV2Client.GetGroupAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<GroupsV2.GroupResponse>(uri);
		}

		GroupsV2.GroupResponse IGroupV2Client.GetGroupByName(string groupName, GroupsV2.GroupType groupType) => GroupV2.GetGroupByNameAsync(groupName, groupType).GetAwaiter().GetResult();
		Task<GroupsV2.GroupResponse> IGroupV2Client.GetGroupByNameAsync(string groupName, GroupsV2.GroupType groupType)
		{
			if (groupName is null)
				throw new ArgumentNullException(nameof(groupName));
			string[] pathSegments = new string[] { "GroupV2", "Name", groupName, ((int)groupType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<GroupsV2.GroupResponse>(uri);
		}

		GroupsV2.GroupOptionalConversation[] IGroupV2Client.GetGroupOptionalConversations(long groupId) => GroupV2.GetGroupOptionalConversationsAsync(groupId).GetAwaiter().GetResult();
		Task<GroupsV2.GroupOptionalConversation[]> IGroupV2Client.GetGroupOptionalConversationsAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "OptionalConversations" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityArrayAsync<GroupsV2.GroupOptionalConversation>(uri);
		}

		GroupsV2.GroupCreationResponse IGroupV2Client.CreateGroup() => GroupV2.CreateGroupAsync().GetAwaiter().GetResult();
		Task<GroupsV2.GroupCreationResponse> IGroupV2Client.CreateGroupAsync()
		{
			string[] pathSegments = new string[] { "GroupV2", "Create" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupCreationResponse>(uri);
		}

		int IGroupV2Client.EditGroup(long groupId) => GroupV2.EditGroupAsync(groupId).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.EditGroupAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Edit" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		int IGroupV2Client.EditClanBanner(long groupId) => GroupV2.EditClanBannerAsync(groupId).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.EditClanBannerAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "EditClanBanner" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		int IGroupV2Client.EditFounderOptions(long groupId) => GroupV2.EditFounderOptionsAsync(groupId).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.EditFounderOptionsAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "EditFounderOptions" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		long IGroupV2Client.AddOptionalConversation(long groupId) => GroupV2.AddOptionalConversationAsync(groupId).GetAwaiter().GetResult();
		Task<long> IGroupV2Client.AddOptionalConversationAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "OptionalConversations", "Add" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<long>(uri);
		}

		long IGroupV2Client.EditOptionalConversation(long groupId, long conversationId) => GroupV2.EditOptionalConversationAsync(groupId, conversationId).GetAwaiter().GetResult();
		Task<long> IGroupV2Client.EditOptionalConversationAsync(long groupId, long conversationId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "OptionalConversations", "Edit", conversationId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<long>(uri);
		}

		SearchResultOfGroupMember IGroupV2Client.GetMembersOfGroup(long groupId, int currentpage, GroupsV2.RuntimeGroupMemberType memberType, string nameSearch) => GroupV2.GetMembersOfGroupAsync(groupId, currentpage, memberType, nameSearch).GetAwaiter().GetResult();
		Task<SearchResultOfGroupMember> IGroupV2Client.GetMembersOfGroupAsync(long groupId, int currentpage, GroupsV2.RuntimeGroupMemberType memberType, string nameSearch)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString()),
				new QueryStringItem("memberType", ((int)memberType).ToString()),
				new QueryStringItem("nameSearch", (nameSearch ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<SearchResultOfGroupMember>(uri);
		}

		SearchResultOfGroupMember IGroupV2Client.GetAdminsAndFounderOfGroup(long groupId, int currentpage) => GroupV2.GetAdminsAndFounderOfGroupAsync(groupId, currentpage).GetAwaiter().GetResult();
		Task<SearchResultOfGroupMember> IGroupV2Client.GetAdminsAndFounderOfGroupAsync(long groupId, int currentpage)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "AdminsAndFounder" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<SearchResultOfGroupMember>(uri);
		}

		int IGroupV2Client.EditGroupMembership(long groupId, BungieMembershipType membershipType, long membershipId, GroupsV2.RuntimeGroupMemberType memberType) => GroupV2.EditGroupMembershipAsync(groupId, membershipType, membershipId, memberType).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.EditGroupMembershipAsync(long groupId, BungieMembershipType membershipType, long membershipId, GroupsV2.RuntimeGroupMemberType memberType)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", ((int)membershipType).ToString(), membershipId.ToString(), "SetMembershipType", ((int)memberType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		GroupsV2.GroupMemberLeaveResult IGroupV2Client.KickMember(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.KickMemberAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<GroupsV2.GroupMemberLeaveResult> IGroupV2Client.KickMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", ((int)membershipType).ToString(), membershipId.ToString(), "Kick" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupMemberLeaveResult>(uri);
		}

		int IGroupV2Client.BanMember(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.BanMemberAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.BanMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", ((int)membershipType).ToString(), membershipId.ToString(), "Ban" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		int IGroupV2Client.UnbanMember(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.UnbanMemberAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<int> IGroupV2Client.UnbanMemberAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", ((int)membershipType).ToString(), membershipId.ToString(), "Unban" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<int>(uri);
		}

		SearchResultOfGroupBan IGroupV2Client.GetBannedMembersOfGroup(long groupId, int currentpage) => GroupV2.GetBannedMembersOfGroupAsync(groupId, currentpage).GetAwaiter().GetResult();
		Task<SearchResultOfGroupBan> IGroupV2Client.GetBannedMembersOfGroupAsync(long groupId, int currentpage)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Banned" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<SearchResultOfGroupBan>(uri);
		}

		bool IGroupV2Client.AbdicateFoundership(long groupId, BungieMembershipType membershipType, long founderIdNew) => GroupV2.AbdicateFoundershipAsync(groupId, membershipType, founderIdNew).GetAwaiter().GetResult();
		Task<bool> IGroupV2Client.AbdicateFoundershipAsync(long groupId, BungieMembershipType membershipType, long founderIdNew)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Admin", "AbdicateFoundership", ((int)membershipType).ToString(), founderIdNew.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<bool>(uri);
		}

		GroupsV2.GroupApplicationResponse IGroupV2Client.RequestGroupMembership(long groupId, BungieMembershipType membershipType) => GroupV2.RequestGroupMembershipAsync(groupId, membershipType).GetAwaiter().GetResult();
		Task<GroupsV2.GroupApplicationResponse> IGroupV2Client.RequestGroupMembershipAsync(long groupId, BungieMembershipType membershipType)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "Apply", ((int)membershipType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupApplicationResponse>(uri);
		}

		SearchResultOfGroupMemberApplication IGroupV2Client.GetPendingMemberships(long groupId, int currentpage) => GroupV2.GetPendingMembershipsAsync(groupId, currentpage).GetAwaiter().GetResult();
		Task<SearchResultOfGroupMemberApplication> IGroupV2Client.GetPendingMembershipsAsync(long groupId, int currentpage)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "Pending" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<SearchResultOfGroupMemberApplication>(uri);
		}

		SearchResultOfGroupMemberApplication IGroupV2Client.GetInvitedIndividuals(long groupId, int currentpage) => GroupV2.GetInvitedIndividualsAsync(groupId, currentpage).GetAwaiter().GetResult();
		Task<SearchResultOfGroupMemberApplication> IGroupV2Client.GetInvitedIndividualsAsync(long groupId, int currentpage)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "InvitedIndividuals" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<SearchResultOfGroupMemberApplication>(uri);
		}

		GroupsV2.GroupMemberLeaveResult IGroupV2Client.RescindGroupMembership(long groupId, BungieMembershipType membershipType) => GroupV2.RescindGroupMembershipAsync(groupId, membershipType).GetAwaiter().GetResult();
		Task<GroupsV2.GroupMemberLeaveResult> IGroupV2Client.RescindGroupMembershipAsync(long groupId, BungieMembershipType membershipType)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "Rescind", ((int)membershipType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupMemberLeaveResult>(uri);
		}

		Entities.EntityActionResult[] IGroupV2Client.ApproveAllPending(long groupId) => GroupV2.ApproveAllPendingAsync(groupId).GetAwaiter().GetResult();
		Task<Entities.EntityActionResult[]> IGroupV2Client.ApproveAllPendingAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "ApproveAll" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<Entities.EntityActionResult>(uri);
		}

		Entities.EntityActionResult[] IGroupV2Client.DenyAllPending(long groupId) => GroupV2.DenyAllPendingAsync(groupId).GetAwaiter().GetResult();
		Task<Entities.EntityActionResult[]> IGroupV2Client.DenyAllPendingAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "DenyAll" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<Entities.EntityActionResult>(uri);
		}

		Entities.EntityActionResult[] IGroupV2Client.ApprovePendingForList(long groupId) => GroupV2.ApprovePendingForListAsync(groupId).GetAwaiter().GetResult();
		Task<Entities.EntityActionResult[]> IGroupV2Client.ApprovePendingForListAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "ApproveList" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<Entities.EntityActionResult>(uri);
		}

		bool IGroupV2Client.ApprovePending(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.ApprovePendingAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<bool> IGroupV2Client.ApprovePendingAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "Approve", ((int)membershipType).ToString(), membershipId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<bool>(uri);
		}

		Entities.EntityActionResult[] IGroupV2Client.DenyPendingForList(long groupId) => GroupV2.DenyPendingForListAsync(groupId).GetAwaiter().GetResult();
		Task<Entities.EntityActionResult[]> IGroupV2Client.DenyPendingForListAsync(long groupId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "DenyList" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<Entities.EntityActionResult>(uri);
		}

		GroupsV2.GroupMembershipSearchResponse IGroupV2Client.GetGroupsForMember(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupsForMemberFilter filter, GroupsV2.GroupType groupType) => GroupV2.GetGroupsForMemberAsync(membershipType, membershipId, filter, groupType).GetAwaiter().GetResult();
		Task<GroupsV2.GroupMembershipSearchResponse> IGroupV2Client.GetGroupsForMemberAsync(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupsForMemberFilter filter, GroupsV2.GroupType groupType)
		{
			string[] pathSegments = new string[] { "GroupV2", "User", ((int)membershipType).ToString(), membershipId.ToString(), ((int)filter).ToString(), ((int)groupType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<GroupsV2.GroupMembershipSearchResponse>(uri);
		}

		GroupsV2.GroupPotentialMembershipSearchResponse IGroupV2Client.GetPotentialGroupsForMember(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupPotentialMemberStatus filter, GroupsV2.GroupType groupType) => GroupV2.GetPotentialGroupsForMemberAsync(membershipType, membershipId, filter, groupType).GetAwaiter().GetResult();
		Task<GroupsV2.GroupPotentialMembershipSearchResponse> IGroupV2Client.GetPotentialGroupsForMemberAsync(BungieMembershipType membershipType, long membershipId, GroupsV2.GroupPotentialMemberStatus filter, GroupsV2.GroupType groupType)
		{
			string[] pathSegments = new string[] { "GroupV2", "User", "Potential", ((int)membershipType).ToString(), membershipId.ToString(), ((int)filter).ToString(), ((int)groupType).ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<GroupsV2.GroupPotentialMembershipSearchResponse>(uri);
		}

		GroupsV2.GroupApplicationResponse IGroupV2Client.IndividualGroupInvite(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.IndividualGroupInviteAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<GroupsV2.GroupApplicationResponse> IGroupV2Client.IndividualGroupInviteAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "IndividualInvite", ((int)membershipType).ToString(), membershipId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupApplicationResponse>(uri);
		}

		GroupsV2.GroupApplicationResponse IGroupV2Client.IndividualGroupInviteCancel(long groupId, BungieMembershipType membershipType, long membershipId) => GroupV2.IndividualGroupInviteCancelAsync(groupId, membershipType, membershipId).GetAwaiter().GetResult();
		Task<GroupsV2.GroupApplicationResponse> IGroupV2Client.IndividualGroupInviteCancelAsync(long groupId, BungieMembershipType membershipType, long membershipId)
		{
			string[] pathSegments = new string[] { "GroupV2", groupId.ToString(), "Members", "IndividualInviteCancel", ((int)membershipType).ToString(), membershipId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<GroupsV2.GroupApplicationResponse>(uri);
		}
	}
}
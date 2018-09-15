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
	public interface IForumClient
	{
		Forum.PostSearchResponse GetTopicsPaged(int page, int pageSize, long group, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, string tagstring);
		Task<Forum.PostSearchResponse> GetTopicsPagedAsync(int page, int pageSize, long group, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, string tagstring);

		Forum.PostSearchResponse GetCoreTopicsPaged(int page, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales);
		Task<Forum.PostSearchResponse> GetCoreTopicsPagedAsync(int page, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales);

		Forum.PostSearchResponse GetPostsThreadedPaged(long parentPostId, int page, int pageSize, int replySize, bool getParentPost, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned);
		Task<Forum.PostSearchResponse> GetPostsThreadedPagedAsync(long parentPostId, int page, int pageSize, int replySize, bool getParentPost, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned);

		Forum.PostSearchResponse GetPostsThreadedPagedFromChild(long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned);
		Task<Forum.PostSearchResponse> GetPostsThreadedPagedFromChildAsync(long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned);

		Forum.PostSearchResponse GetPostAndParent(long childPostId, string showbanned);
		Task<Forum.PostSearchResponse> GetPostAndParentAsync(long childPostId, string showbanned);

		Forum.PostSearchResponse GetPostAndParentAwaitingApproval(long childPostId, string showbanned);
		Task<Forum.PostSearchResponse> GetPostAndParentAwaitingApprovalAsync(long childPostId, string showbanned);

		long GetTopicForContent(long contentId);
		Task<long> GetTopicForContentAsync(long contentId);

		Tags.Models.Contracts.TagResponse[] GetForumTagSuggestions(string partialtag);
		Task<Tags.Models.Contracts.TagResponse[]> GetForumTagSuggestionsAsync(string partialtag);

		Forum.PostSearchResponse GetPoll(long topicId);
		Task<Forum.PostSearchResponse> GetPollAsync(long topicId);

		Forum.ForumRecruitmentDetail JoinFireteamThread(long topicId);
		Task<Forum.ForumRecruitmentDetail> JoinFireteamThreadAsync(long topicId);

		Forum.ForumRecruitmentDetail LeaveFireteamThread(long topicId);
		Task<Forum.ForumRecruitmentDetail> LeaveFireteamThreadAsync(long topicId);

		Forum.ForumRecruitmentDetail KickBanFireteamApplicant(long topicId, long targetMembershipId);
		Task<Forum.ForumRecruitmentDetail> KickBanFireteamApplicantAsync(long topicId, long targetMembershipId);

		Messages.Responses.SaveMessageResult ApproveFireteamThread(long topicId);
		Task<Messages.Responses.SaveMessageResult> ApproveFireteamThreadAsync(long topicId);

		Forum.ForumRecruitmentDetail[] GetRecruitmentThreadSummaries();
		Task<Forum.ForumRecruitmentDetail[]> GetRecruitmentThreadSummariesAsync();
	}

	partial class BungieClient : IForumClient
	{
		public IForumClient Forum => this;


		Forum.PostSearchResponse IForumClient.GetTopicsPaged(int page, int pageSize, long group, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, string tagstring) => Forum.GetTopicsPagedAsync(page, pageSize, group, sort, quickDate, categoryFilter, locales, tagstring).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetTopicsPagedAsync(int page, int pageSize, long group, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, string tagstring)
		{
			string[] pathSegments = new string[] { "Forum", "GetTopicsPaged", page.ToString(), pageSize.ToString(), group.ToString(), ((byte)sort).ToString(), ((int)quickDate).ToString(), ((int)categoryFilter).ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("locales", (locales ?? "")),
				new QueryStringItem("tagstring", (tagstring ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetCoreTopicsPaged(int page, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales) => Forum.GetCoreTopicsPagedAsync(page, sort, quickDate, categoryFilter, locales).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetCoreTopicsPagedAsync(int page, Forum.ForumTopicsSortEnum sort, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales)
		{
			string[] pathSegments = new string[] { "Forum", "GetCoreTopicsPaged", page.ToString(), ((byte)sort).ToString(), ((int)quickDate).ToString(), ((int)categoryFilter).ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("locales", (locales ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetPostsThreadedPaged(long parentPostId, int page, int pageSize, int replySize, bool getParentPost, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned) => Forum.GetPostsThreadedPagedAsync(parentPostId, page, pageSize, replySize, getParentPost, rootThreadMode, sortMode, showbanned).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetPostsThreadedPagedAsync(long parentPostId, int page, int pageSize, int replySize, bool getParentPost, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned)
		{
			string[] pathSegments = new string[] { "Forum", "GetPostsThreadedPaged", parentPostId.ToString(), page.ToString(), pageSize.ToString(), replySize.ToString(), getParentPost.ToString(), rootThreadMode.ToString(), ((int)sortMode).ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("showbanned", (showbanned ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetPostsThreadedPagedFromChild(long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned) => Forum.GetPostsThreadedPagedFromChildAsync(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetPostsThreadedPagedFromChildAsync(long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, Forum.ForumPostSortEnum sortMode, string showbanned)
		{
			string[] pathSegments = new string[] { "Forum", "GetPostsThreadedPagedFromChild", childPostId.ToString(), page.ToString(), pageSize.ToString(), replySize.ToString(), rootThreadMode.ToString(), ((int)sortMode).ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("showbanned", (showbanned ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetPostAndParent(long childPostId, string showbanned) => Forum.GetPostAndParentAsync(childPostId, showbanned).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetPostAndParentAsync(long childPostId, string showbanned)
		{
			string[] pathSegments = new string[] { "Forum", "GetPostAndParent", childPostId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("showbanned", (showbanned ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetPostAndParentAwaitingApproval(long childPostId, string showbanned) => Forum.GetPostAndParentAwaitingApprovalAsync(childPostId, showbanned).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetPostAndParentAwaitingApprovalAsync(long childPostId, string showbanned)
		{
			string[] pathSegments = new string[] { "Forum", "GetPostAndParentAwaitingApproval", childPostId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("showbanned", (showbanned ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		long IForumClient.GetTopicForContent(long contentId) => Forum.GetTopicForContentAsync(contentId).GetAwaiter().GetResult();
		Task<long> IForumClient.GetTopicForContentAsync(long contentId)
		{
			string[] pathSegments = new string[] { "Forum", "GetTopicForContent", contentId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<long>(uri);
		}

		Tags.Models.Contracts.TagResponse[] IForumClient.GetForumTagSuggestions(string partialtag) => Forum.GetForumTagSuggestionsAsync(partialtag).GetAwaiter().GetResult();
		Task<Tags.Models.Contracts.TagResponse[]> IForumClient.GetForumTagSuggestionsAsync(string partialtag)
		{
			string[] pathSegments = new string[] { "Forum", "GetForumTagSuggestions" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("partialtag", (partialtag ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityArrayAsync<Tags.Models.Contracts.TagResponse>(uri);
		}

		Forum.PostSearchResponse IForumClient.GetPoll(long topicId) => Forum.GetPollAsync(topicId).GetAwaiter().GetResult();
		Task<Forum.PostSearchResponse> IForumClient.GetPollAsync(long topicId)
		{
			string[] pathSegments = new string[] { "Forum", "Poll", topicId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Forum.PostSearchResponse>(uri);
		}

		Forum.ForumRecruitmentDetail IForumClient.JoinFireteamThread(long topicId) => Forum.JoinFireteamThreadAsync(topicId).GetAwaiter().GetResult();
		Task<Forum.ForumRecruitmentDetail> IForumClient.JoinFireteamThreadAsync(long topicId)
		{
			string[] pathSegments = new string[] { "Forum", "Recruit", "Join", topicId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Forum.ForumRecruitmentDetail>(uri);
		}

		Forum.ForumRecruitmentDetail IForumClient.LeaveFireteamThread(long topicId) => Forum.LeaveFireteamThreadAsync(topicId).GetAwaiter().GetResult();
		Task<Forum.ForumRecruitmentDetail> IForumClient.LeaveFireteamThreadAsync(long topicId)
		{
			string[] pathSegments = new string[] { "Forum", "Recruit", "Leave", topicId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Forum.ForumRecruitmentDetail>(uri);
		}

		Forum.ForumRecruitmentDetail IForumClient.KickBanFireteamApplicant(long topicId, long targetMembershipId) => Forum.KickBanFireteamApplicantAsync(topicId, targetMembershipId).GetAwaiter().GetResult();
		Task<Forum.ForumRecruitmentDetail> IForumClient.KickBanFireteamApplicantAsync(long topicId, long targetMembershipId)
		{
			string[] pathSegments = new string[] { "Forum", "Recruit", "KickBan", topicId.ToString(), targetMembershipId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Forum.ForumRecruitmentDetail>(uri);
		}

		Messages.Responses.SaveMessageResult IForumClient.ApproveFireteamThread(long topicId) => Forum.ApproveFireteamThreadAsync(topicId).GetAwaiter().GetResult();
		Task<Messages.Responses.SaveMessageResult> IForumClient.ApproveFireteamThreadAsync(long topicId)
		{
			string[] pathSegments = new string[] { "Forum", "Recruit", "Approve", topicId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityAsync<Messages.Responses.SaveMessageResult>(uri);
		}

		Forum.ForumRecruitmentDetail[] IForumClient.GetRecruitmentThreadSummaries() => Forum.GetRecruitmentThreadSummariesAsync().GetAwaiter().GetResult();
		Task<Forum.ForumRecruitmentDetail[]> IForumClient.GetRecruitmentThreadSummariesAsync()
		{
			string[] pathSegments = new string[] { "Forum", "Recruit", "Summaries" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return PostEntityArrayAsync<Forum.ForumRecruitmentDetail>(uri);
		}
	}
}

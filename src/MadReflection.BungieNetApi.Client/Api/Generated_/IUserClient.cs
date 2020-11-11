﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BungieNet.Api
{
	public interface IUserClient
	{
		User.GeneralUser GetBungieNetUserById(long id);
		Task<User.GeneralUser> GetBungieNetUserByIdAsync(long id);

		User.GeneralUser[] SearchUsers(string q);
		Task<User.GeneralUser[]> SearchUsersAsync(string q);

		User.Models.GetCredentialTypesForAccountResponse[] GetCredentialTypesForTargetAccount(long membershipId);
		Task<User.Models.GetCredentialTypesForAccountResponse[]> GetCredentialTypesForTargetAccountAsync(long membershipId);

		Config.UserTheme[] GetAvailableThemes();
		Task<Config.UserTheme[]> GetAvailableThemesAsync();

		User.UserMembershipData GetMembershipDataById(long membershipId, BungieMembershipType membershipType);
		Task<User.UserMembershipData> GetMembershipDataByIdAsync(long membershipId, BungieMembershipType membershipType);

		User.UserMembershipData GetMembershipDataForCurrentUser();
		Task<User.UserMembershipData> GetMembershipDataForCurrentUserAsync();

		User.HardLinkedUserMembership GetMembershipFromHardLinkedCredential(BungieCredentialType crType, string credential);
		Task<User.HardLinkedUserMembership> GetMembershipFromHardLinkedCredentialAsync(BungieCredentialType crType, string credential);
	}

	partial interface IBungieClient
	{
		IUserClient User { get; }
	}

	partial class BungieClient : IUserClient
	{
		public IUserClient User => this;


		User.GeneralUser IUserClient.GetBungieNetUserById(long id) => User.GetBungieNetUserByIdAsync(id).GetAwaiter().GetResult();
		Task<User.GeneralUser> IUserClient.GetBungieNetUserByIdAsync(long id)
		{
			string[] pathSegments = new string[] { "User", "GetBungieNetUserById", id.ToString() };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityAsync<User.GeneralUser>(uri);
		}

		User.GeneralUser[] IUserClient.SearchUsers(string q) => User.SearchUsersAsync(q).GetAwaiter().GetResult();
		Task<User.GeneralUser[]> IUserClient.SearchUsersAsync(string q)
		{
			string[] pathSegments = new string[] { "User", "SearchUsers" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("q", (q ?? ""))
			};
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, queryItems);
			return GetEntityArrayAsync<User.GeneralUser>(uri);
		}

		User.Models.GetCredentialTypesForAccountResponse[] IUserClient.GetCredentialTypesForTargetAccount(long membershipId) => User.GetCredentialTypesForTargetAccountAsync(membershipId).GetAwaiter().GetResult();
		Task<User.Models.GetCredentialTypesForAccountResponse[]> IUserClient.GetCredentialTypesForTargetAccountAsync(long membershipId)
		{
			string[] pathSegments = new string[] { "User", "GetCredentialTypesForTargetAccount", membershipId.ToString() };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityArrayAsync<User.Models.GetCredentialTypesForAccountResponse>(uri);
		}

		Config.UserTheme[] IUserClient.GetAvailableThemes() => User.GetAvailableThemesAsync().GetAwaiter().GetResult();
		Task<Config.UserTheme[]> IUserClient.GetAvailableThemesAsync()
		{
			string[] pathSegments = new string[] { "User", "GetAvailableThemes" };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityArrayAsync<Config.UserTheme>(uri);
		}

		User.UserMembershipData IUserClient.GetMembershipDataById(long membershipId, BungieMembershipType membershipType) => User.GetMembershipDataByIdAsync(membershipId, membershipType).GetAwaiter().GetResult();
		Task<User.UserMembershipData> IUserClient.GetMembershipDataByIdAsync(long membershipId, BungieMembershipType membershipType)
		{
			string[] pathSegments = new string[] { "User", "GetMembershipsById", membershipId.ToString(), ((int)membershipType).ToString() };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityAsync<User.UserMembershipData>(uri);
		}

		User.UserMembershipData IUserClient.GetMembershipDataForCurrentUser() => User.GetMembershipDataForCurrentUserAsync().GetAwaiter().GetResult();
		Task<User.UserMembershipData> IUserClient.GetMembershipDataForCurrentUserAsync()
		{
			string[] pathSegments = new string[] { "User", "GetMembershipsForCurrentUser" };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityAsync<User.UserMembershipData>(uri);
		}

		User.HardLinkedUserMembership IUserClient.GetMembershipFromHardLinkedCredential(BungieCredentialType crType, string credential) => User.GetMembershipFromHardLinkedCredentialAsync(crType, credential).GetAwaiter().GetResult();
		Task<User.HardLinkedUserMembership> IUserClient.GetMembershipFromHardLinkedCredentialAsync(BungieCredentialType crType, string credential)
		{
			if (credential is null)
				throw new ArgumentNullException(nameof(credential));
			string[] pathSegments = new string[] { "User", "GetMembershipFromHardLinkedCredential", ((byte)crType).ToString(), credential };
			Uri uri = GetEndpointUri(BungieEndpointBase.Default, pathSegments, true, null);
			return GetEntityAsync<User.HardLinkedUserMembership>(uri);
		}
	}
}

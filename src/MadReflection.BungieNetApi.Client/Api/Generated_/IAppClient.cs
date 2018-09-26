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
	public interface IAppClient
	{
		Applications.ApiUsage GetApplicationApiUsage(int applicationId, DateTime end, DateTime start);
		Task<Applications.ApiUsage> GetApplicationApiUsageAsync(int applicationId, DateTime end, DateTime start);

		Applications.Application[] GetBungieApplications();
		Task<Applications.Application[]> GetBungieApplicationsAsync();

		System.Collections.Generic.Dictionary<string, string> GetAvailableLocales();
		Task<System.Collections.Generic.Dictionary<string, string>> GetAvailableLocalesAsync();

		Common.Models.CoreSettingsConfiguration GetCommonSettings();
		Task<Common.Models.CoreSettingsConfiguration> GetCommonSettingsAsync();

		GlobalAlert[] GetGlobalAlerts(bool includestreaming);
		Task<GlobalAlert[]> GetGlobalAlertsAsync(bool includestreaming);
	}

	partial interface IBungieClient
	{
		IAppClient App { get; }
	}

	partial class BungieClient : IAppClient
	{
		public IAppClient App => this;


		Applications.ApiUsage IAppClient.GetApplicationApiUsage(int applicationId, DateTime end, DateTime start) => App.GetApplicationApiUsageAsync(applicationId, end, start).GetAwaiter().GetResult();
		Task<Applications.ApiUsage> IAppClient.GetApplicationApiUsageAsync(int applicationId, DateTime end, DateTime start)
		{
			string[] pathSegments = new string[] { "App", "ApiUsage", applicationId.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("end", end.ToString()),
				new QueryStringItem("start", start.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityAsync<Applications.ApiUsage>(uri);
		}

		Applications.Application[] IAppClient.GetBungieApplications() => App.GetBungieApplicationsAsync().GetAwaiter().GetResult();
		Task<Applications.Application[]> IAppClient.GetBungieApplicationsAsync()
		{
			string[] pathSegments = new string[] { "App", "FirstParty" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityArrayAsync<Applications.Application>(uri);
		}

		System.Collections.Generic.Dictionary<string, string> IAppClient.GetAvailableLocales() => App.GetAvailableLocalesAsync().GetAwaiter().GetResult();
		Task<System.Collections.Generic.Dictionary<string, string>> IAppClient.GetAvailableLocalesAsync()
		{
			string[] pathSegments = new string[] { "GetAvailableLocales" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<System.Collections.Generic.Dictionary<string, string>>(uri);
		}

		Common.Models.CoreSettingsConfiguration IAppClient.GetCommonSettings() => App.GetCommonSettingsAsync().GetAwaiter().GetResult();
		Task<Common.Models.CoreSettingsConfiguration> IAppClient.GetCommonSettingsAsync()
		{
			string[] pathSegments = new string[] { "Settings" };
			Uri uri = GetEndpointUri(pathSegments, null);
			return GetEntityAsync<Common.Models.CoreSettingsConfiguration>(uri);
		}

		GlobalAlert[] IAppClient.GetGlobalAlerts(bool includestreaming) => App.GetGlobalAlertsAsync(includestreaming).GetAwaiter().GetResult();
		Task<GlobalAlert[]> IAppClient.GetGlobalAlertsAsync(bool includestreaming)
		{
			string[] pathSegments = new string[] { "GlobalAlerts" };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("includestreaming", includestreaming.ToString().ToLower())
			};
			Uri uri = GetEndpointUri(pathSegments, queryItems);
			return GetEntityArrayAsync<GlobalAlert>(uri);
		}
	}
}

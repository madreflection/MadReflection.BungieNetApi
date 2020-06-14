using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BungieNet.Api
{
	public abstract class BungieClientBase
	{
		private readonly HttpClient _httpClient;
		private readonly string _apiKey;
		private string _bearerToken;


		private protected BungieClientBase(IBungieApiKey apiKey)
		{
			if (apiKey == null)
				throw new ArgumentNullException(nameof(apiKey));
			if (apiKey.Value == "")
				throw new ArgumentException("API key value cannot be an empty string.", nameof(apiKey) + "." + nameof(apiKey.Value));

			_httpClient = new HttpClient();
			_apiKey = apiKey.Value;
		}


		public void SetBearerToken(string bearerToken)
		{
			if (bearerToken == null)
				throw new ArgumentNullException(nameof(bearerToken));
			if (string.IsNullOrEmpty(bearerToken))
				throw new ArgumentException("Bearer token cannot be an empty string.", nameof(bearerToken));

			_bearerToken = bearerToken;
		}

		public void ClearBearerToken()
		{
			_bearerToken = null;
		}

		internal Uri GetEndpointUri(BungieEndpointBase endpointBase, string[] pathSegments, bool includeTrailingSlash, IEnumerable<QueryStringItem> queryStringItems = null)
		{
			if (pathSegments == null)
				throw new ArgumentNullException(nameof(pathSegments));
			if (pathSegments.Length == 0)
				throw new ArgumentException("No endpoint path.");

			foreach (string pathSegment in pathSegments)
			{
				if (pathSegment == null)
					throw new ArgumentNullException(nameof(pathSegment), "Array elements cannot be null.");
				if (pathSegments.Length == 0)
					throw new ArgumentException("Array element is empty.", nameof(pathSegments));
			}

			UriBuilder builder = new UriBuilder(
				endpointBase switch
				{
					BungieEndpointBase.Destiny1 => Constants.BaseUriD1,
					BungieEndpointBase.Stats => Constants.BaseUriStats,
					_ => Constants.BaseUri
				});

			builder.Path += string.Join("/", pathSegments);
			if (includeTrailingSlash)
				builder.Path += "/";

			if (queryStringItems != null && queryStringItems.Any())
			{
				StringBuilder queryString = new StringBuilder();

				foreach (QueryStringItem queryStringItem in queryStringItems)
					queryString.Append(WebUtility.UrlEncode(queryStringItem.Name)).Append('=').Append(WebUtility.UrlEncode(queryStringItem.Value)).Append("&");

				if (queryString.Length > 0 && queryString[queryString.Length - 1] == '&')
					queryString.Length--;

				builder.Query = queryString.ToString();
			}

			return builder.Uri;
		}

		private HttpRequestMessage CreateRequestMessage(Uri uri, HttpMethod method, HttpContent content)
		{
			HttpRequestMessage request = new HttpRequestMessage()
			{
				Method = method,
				Headers =
				{
					{ "Accept", "text/json" },
					{ "X-API-Key", _apiKey }
				},
				RequestUri = uri,
				Content = content
			};

			if (_bearerToken is object)
				request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _bearerToken);

			return request;
		}

		private async Task<string> GetResourceAsync(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			HttpRequestMessage request = CreateRequestMessage(uri, HttpMethod.Get, null);

			HttpResponseMessage response = await _httpClient.SendAsync(request);

			if (response.StatusCode.IsRedirectCode())
			{
				request = CreateRequestMessage(response.Headers.Location, HttpMethod.Get, null);
				response = await _httpClient.SendAsync(request);
			}

			if (response.StatusCode.IsRedirectCode())
				throw new BungieClientException("Multiple redirects detected.");

			return await response.Content.ReadAsStringAsync();
		}

		private async Task<string> PostResourceAsync(Uri uri, string postBody)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			StringContent content = new StringContent(postBody);

			HttpRequestMessage request = CreateRequestMessage(uri, HttpMethod.Post, content);

			HttpResponseMessage response = await _httpClient.SendAsync(request);

			if (response.StatusCode.IsRedirectCode())
			{
				request = CreateRequestMessage(response.Headers.Location, HttpMethod.Post, content);
				response = await _httpClient.SendAsync(request);
			}

			if (response.StatusCode.IsRedirectCode())
				throw new BungieClientException("Multiple redirects detected.");

			return await response.Content.ReadAsStringAsync();
		}

		private async Task<JToken> GetObjectAsync(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			string response = await GetResourceAsync(uri);

			JObject jObject = JObject.Parse(response);

			int errorCode = (int)jObject["ErrorCode"];
			if (errorCode != 1)
				throw new BungieException((Exceptions.PlatformErrorCodes)errorCode, (string)jObject["ErrorStatus"], (string)jObject["Message"], jObject["MessageData"]);

			return jObject["Response"];
		}

		private async Task<JToken> PostObjectAsync(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			string response = await PostResourceAsync(uri, "");

			JObject jObject = JObject.Parse(response);

			int errorCode = (int)jObject["ErrorCode"];
			if (errorCode != 1)
				throw new BungieException((Exceptions.PlatformErrorCodes)errorCode, (string)jObject["ErrorStatus"], (string)jObject["Message"], jObject["MessageData"]);

			return jObject["Response"];
		}

		private async Task<JToken> PostObjectAsync(Uri uri, JToken inputObject)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			string request = inputObject.ToString(Formatting.None);

			string response = await PostResourceAsync(uri, request);

			JObject jObject = JObject.Parse(response);

			int errorCode = (int)jObject["ErrorCode"];
			if (errorCode != 1)
				throw new BungieException((Exceptions.PlatformErrorCodes)errorCode, (string)jObject["ErrorStatus"], (string)jObject["Message"], jObject["MessageData"]);

			return jObject["Response"];
		}

		protected async Task<TOutput> GetEntityAsync<TOutput>(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JObject response = (JObject)await GetObjectAsync(uri);
			if (response is null)
				return default;

			return response.ToObject<TOutput>();
		}

		protected async Task<TOutput> PostEntityAsync<TOutput>(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JObject response = (JObject)await PostObjectAsync(uri);

			return response.ToObject<TOutput>();
		}

		protected async Task<TOutput> PostEntityAsync<TInput, TOutput>(Uri uri, TInput inputObject)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JToken request = JsonConvert.SerializeObject(inputObject, Formatting.None);

			JObject response = (JObject)await PostObjectAsync(uri, request);

			return response.ToObject<TOutput>();
		}

		protected async Task<TOutput[]> GetEntityArrayAsync<TOutput>(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JArray response = (JArray)await GetObjectAsync(uri);

			return response.ToObject<TOutput[]>();
		}

		protected async Task<TOutput[]> PostEntityArrayAsync<TOutput>(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JArray response = (JArray)await PostObjectAsync(uri);

			return response.ToObject<TOutput[]>();
		}

		protected async Task<TOutput[]> PostEntityArrayAsync<TInput, TOutput>(Uri uri, TInput inputObject)
		{
			if (uri == null)
				throw new ArgumentNullException(nameof(uri));

			JToken request = JsonConvert.SerializeObject(inputObject, Formatting.None);

			JArray response = (JArray)await PostObjectAsync(uri, request);

			return response.ToObject<TOutput[]>();
		}
	}
}

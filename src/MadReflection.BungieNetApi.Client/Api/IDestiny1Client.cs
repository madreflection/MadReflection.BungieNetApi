using System;
using System.Threading.Tasks;
using BungieNet.Destiny.Config;

namespace BungieNet.Api
{
	public interface IDestiny1Client
	{
		[Undocumented]
		DestinyManifest GetDestinyManifest();
		[Undocumented]
		Task<DestinyManifest> GetDestinyManifestAsync();
	}

	partial interface IBungieClient
	{
		[Undocumented]
		IDestiny1Client Destiny1 { get; }
	}

	partial class BungieClient : IDestiny1Client
	{
		[Undocumented]
		public IDestiny1Client Destiny1 => this;


		DestinyManifest IDestiny1Client.GetDestinyManifest() => Destiny1.GetDestinyManifestAsync().GetAwaiter().GetResult();
		Task<DestinyManifest> IDestiny1Client.GetDestinyManifestAsync()
		{
			string[] pathSegments = new string[] { "Destiny", "Manifest" };
			Uri uri = GetEndpointUri(BungieEndpointBase.Destiny1, pathSegments, true, null);
			return GetEntityAsync<DestinyManifest>(uri);
		}
	}
}

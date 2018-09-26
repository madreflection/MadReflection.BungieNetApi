using System;

namespace BungieNet.Api
{
	public partial class BungieClient : BungieClientBase, IBungieClient
	{
		public BungieClient(IBungieApiKey apiKey)
			: base(apiKey)
		{
		}
	}
}

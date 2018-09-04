using System;

namespace BungieNet.Api
{
	public partial class BungieClient : BungieClientBase
	{
		public BungieClient(IBungieApiKey apiKey)
			: base(apiKey)
		{
		}
	}
}

using System;
namespace BungieNet.Api
{
	public sealed class BungieApiKey : IBungieApiKey
	{
		public BungieApiKey(string key)
		{
			Value = key ?? throw new ArgumentNullException(nameof(key));
		}


		public string Value { get; }
	}
}

using BungieNet.Api;
using NUnit.Framework;

namespace MadReflection.BungieNetApi.Tests
{
	[TestFixture]
	public class Destiny1_Tests
	{
		private IBungieClient _client;


		[SetUp]
		public void SetUp()
		{
			_client = new BungieClient(new BungieApiKey(Constants.TestApiKey));
		}

		[TearDown]
		public void TearDown()
		{
		}


		[Test]
		public void GetDestinyManifest()
		{
			// Arrange

			// Act
			_client.Destiny1.GetDestinyManifest();

			// Assert
		}
	}
}

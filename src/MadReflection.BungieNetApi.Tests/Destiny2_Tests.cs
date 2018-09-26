using BungieNet;
using BungieNet.Api;
using BungieNet.Destiny;
using BungieNet.Destiny.Config;
using BungieNet.Destiny.Responses;
using BungieNet.User;
using NUnit.Framework;

namespace MadReflection.BungieNetApi.Tests
{
	public class Destiny2_Tests
	{
		private IBungieClient _client;


		[SetUp]
		public void SetUp()
		{
			// This is the API key for the DEV application.  If something goes wrong with it, it's no big deal to sever it.
			_client = new BungieClient(new BungieApiKey("77dd2016bdb346cf82751aae4a38661b"));
		}

		[TearDown]
		public void TearDown()
		{
		}


		[Test]
		public void Test01_GetDestinyManifest()
		{
			DestinyManifest manifest = _client.Destiny2.GetDestinyManifest();
		}

		[Test]
		public void Test02_SearchDestinyPlayer()
		{
			UserInfoCard[] result = _client.Destiny2.SearchDestinyPlayer(BungieMembershipType.TigerPsn, "my_name_is_Byf");
		}

		[TestCase(4611686018428388975L)]
		public void Test03_GetProfile(long destinyMembershipId)
		{
			DestinyProfileResponse profile = _client.Destiny2.GetProfile(BungieMembershipType.TigerPsn, destinyMembershipId, DestinyComponentTypes.Profile);
		}

		[TestCase(4611686018428388975L, 2305843009261963955L)]
		[TestCase(4611686018428388975L, 2305843009285656339L)]
		[TestCase(4611686018428388975L, 2305843009261963957L)]
		public void Test04_GetCharacter(long destinyMembershipId, long characterId)
		{
			DestinyCharacterResponse character = _client.Destiny2.GetCharacter(BungieMembershipType.TigerPsn, destinyMembershipId, characterId, DestinyComponentTypes.Profile);
		}
	}
}

using BungieNet;
using BungieNet.Api;
using BungieNet.Destiny;
using BungieNet.Destiny.Config;
using BungieNet.Destiny.Responses;
using BungieNet.User;
using NUnit.Framework;

namespace MadReflection.BungieNetApi.Tests
{
	[TestFixture]
	public class Destiny2_Tests
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
		public void Test01_GetDestinyManifest()
		{
			DestinyManifest manifest = _client.Destiny2.GetDestinyManifest();
		}

		[Test]
		public void Test02_SearchDestinyPlayer()
		{
			UserInfoCard[] result = _client.Destiny2.SearchDestinyPlayer(BungieMembershipType.TigerPsn, Constants.APublicFigure_PsnId, false);
		}

		[TestCase(Constants.APublicFigure_MembershipId)]
		public void Test03_GetProfile(long destinyMembershipId)
		{
			DestinyProfileResponse profile = _client.Destiny2.GetProfile(BungieMembershipType.TigerPsn, destinyMembershipId, DestinyComponentTypes.Profile);
		}

		[TestCase(Constants.APublicFigure_MembershipId, Constants.APublicFigure_Character1)]
		[TestCase(Constants.APublicFigure_MembershipId, Constants.APublicFigure_Character2)]
		[TestCase(Constants.APublicFigure_MembershipId, Constants.APublicFigure_Character3)]
		public void Test04_GetCharacter(long destinyMembershipId, long characterId)
		{
			DestinyCharacterResponse character = _client.Destiny2.GetCharacter(BungieMembershipType.TigerPsn, destinyMembershipId, characterId, DestinyComponentTypes.Profile);
		}
	}
}

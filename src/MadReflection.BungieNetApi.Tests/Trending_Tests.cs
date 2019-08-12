using BungieNet;
using BungieNet.Api;
using BungieNet.Trending;
using NUnit.Framework;

namespace MadReflection.BungieNetApi.Tests
{
	[TestFixture]
	public class Trending_Tests
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
		public void Trending1_GetTrendingCategories()
		{
			TrendingCategories categories = _client.Trending.GetTrendingCategories();
		}

		[Test]
		public void Trending2_GetTrendingCategory()
		{
			SearchResultOfTrendingEntry news = _client.Trending.GetTrendingCategory("News", 0);
		}

		[Test]
		public void Trending3_GetTrendingEntryDetail()
		{
			TrendingDetail entryDetail = _client.Trending.GetTrendingEntryDetail(TrendingEntryType.News, "46359");
		}
	}
}

using System;
using BungieNet.Api;
using NUnit.Framework;

namespace MadReflection.BungieNetApi.Tests
{
	// Certain new endpoints in 2.3.6 do not include the trailing slash in the path.  This library
	// was modified to include the trailing slash only if the endpoint requires it.
	// These tests verify that paths with and without a trailing slash are both correctly handled.

	[TestFixture]
	public class TrailingSlash_Tests
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


		[TestCase]
		public void Endpoint_With_Trailing_Slash_Works()
		{
			// Arrange

			// Act
			var result = _client.App.GetBungieApplications();

			// Assert
		}

		[TestCase]
		public void Endpoint_Without_Trailing_Slash_Works()
		{
			// Arrange

			// Act
			var result = _client.Content.SearchHelpArticles("triumph", "10");

			// Assert
		}
	}
}

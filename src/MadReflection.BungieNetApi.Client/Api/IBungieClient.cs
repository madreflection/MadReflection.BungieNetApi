namespace BungieNet.Api
{
	public partial interface IBungieClient
	{
		void SetBearerToken(string bearerToken);
		void ClearBearerToken();
	}
}

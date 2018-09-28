using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions.Records
{
	partial class SchemaRecordStateBlock
	{
		[Undocumented]
		[JsonProperty("completeUnlockHash")]
		public uint CompleteUnlockHash { get; set; }

		[Undocumented]
		[JsonProperty("claimedUnlockHash")]
		public uint ClaimedUnlockHash { get; set; }
	}
}

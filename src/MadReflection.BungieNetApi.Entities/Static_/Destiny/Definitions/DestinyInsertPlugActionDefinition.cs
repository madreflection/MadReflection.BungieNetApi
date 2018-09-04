using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Definitions
{
	partial class DestinyInsertPlugActionDefinition
	{
		[Undocumented]
		[JsonProperty("actionSoundHash")]
		public long ActionSoundHash { get; set; }

		[Undocumented]
		[JsonProperty("isPositiveAction")]
		public bool IsPositiveAction { get; set; }
	}
}

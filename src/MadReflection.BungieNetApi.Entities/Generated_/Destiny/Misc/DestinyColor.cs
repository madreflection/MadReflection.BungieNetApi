﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Misc
{
	/// <summary>
	/// Represents a color whose RGBA values are all represented as values between 0 and 255.
	/// </summary>
	public partial class DestinyColor
	{
		[JsonProperty("red")]
		public byte Red { get; set; }

		[JsonProperty("green")]
		public byte Green { get; set; }

		[JsonProperty("blue")]
		public byte Blue { get; set; }

		[JsonProperty("alpha")]
		public byte Alpha { get; set; }
	}
}

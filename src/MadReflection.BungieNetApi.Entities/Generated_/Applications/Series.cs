﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Applications
{
	public partial class Series
	{
		[JsonProperty("datapoints")]
		public Applications.Datapoint[] Datapoints { get; set; }

		[JsonProperty("target")]
		public string Target { get; set; }
	}
}

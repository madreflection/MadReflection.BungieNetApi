﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Components
{
	/// <summary>
	/// The base class for any component-returning object that may need to indicate information about the state of the component being returned.
	/// </summary>
	public partial class ComponentResponse
	{
		[JsonProperty("privacy")]
		public Components.ComponentPrivacySetting Privacy { get; set; }
	}
}
﻿// -----------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.  Any changes may be lost.
// </auto-generated>
// -----------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Applications
{
	public partial class Application
	{
		[JsonProperty("applicationType")]
		public Applications.OAuthApplicationType ApplicationType { get; set; }

		[JsonProperty("applicationId")]
		public int ApplicationId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("redirectUrl")]
		public string RedirectUrl { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("scope")]
		public long Scope { get; set; }

		[JsonProperty("origin")]
		public string Origin { get; set; }

		[JsonProperty("status")]
		public Applications.ApplicationStatus Status { get; set; }

		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("statusChanged")]
		public DateTime StatusChanged { get; set; }

		[JsonProperty("firstPublished")]
		public DateTime FirstPublished { get; set; }

		[JsonProperty("team")]
		public Applications.ApplicationDeveloper[] Team { get; set; }
	}
}
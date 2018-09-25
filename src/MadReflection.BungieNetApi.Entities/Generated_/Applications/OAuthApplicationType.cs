﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace BungieNet.Applications
{
	public enum OAuthApplicationType
	{
		None = 0,

		/// <summary>
		/// Indicates the application is server based and can keep its secrets from end users and other potential snoops.
		/// </summary>
		Confidential = 1,

		/// <summary>
		/// Indicates the application runs in a public place, and it can't be trusted to keep a secret.
		/// </summary>
		Public = 2
	}
}

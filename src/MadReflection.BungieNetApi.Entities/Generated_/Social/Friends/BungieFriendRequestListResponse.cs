﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Social.Friends
{
	public partial class BungieFriendRequestListResponse
	{
		[JsonProperty("incomingRequests")]
		public Social.Friends.BungieFriend[] IncomingRequests { get; set; }

		[JsonProperty("outgoingRequests")]
		public Social.Friends.BungieFriend[] OutgoingRequests { get; set; }
	}
}

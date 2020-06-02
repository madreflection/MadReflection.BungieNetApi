using System;
using System.Runtime.Serialization;

namespace BungieNet.Api
{
	[Serializable]
	public class BungieClientException : Exception
	{
		#region BungieClientException members
		public BungieClientException(string message)
			: base(message)
		{
		}

		public BungieClientException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
		#endregion


		#region ISerializable members
		protected BungieClientException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}


		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BungieNet
{
	[Serializable]
	public sealed class BungieException : Exception
	{
		#region BungieException members
		public BungieException(Exceptions.PlatformErrorCodes errorCode, string errorStatus, string message, object messageData)
			: base(message)
		{
			ErrorCode = errorCode;
			ErrorStatus = errorStatus;
			//MessageData = messageData;
		}


		public Exceptions.PlatformErrorCodes ErrorCode { get; }

		public string ErrorStatus { get; }

		public Dictionary<string, string> MessageData { get; }
		#endregion


		#region ISerializable members
		private BungieException(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			ErrorCode = (Exceptions.PlatformErrorCodes)info.GetInt32(nameof(ErrorCode));
			ErrorStatus = info.GetString(nameof(ErrorStatus));
			MessageData = (Dictionary<string, string>)info.GetValue(nameof(MessageData), typeof(Dictionary<string, string>));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);

			info.AddValue(nameof(ErrorCode), (int)ErrorCode);
			info.AddValue(nameof(ErrorStatus), ErrorStatus);
			info.AddValue(nameof(MessageData), MessageData, typeof(Dictionary<string, string>));
		}
		#endregion
	}
}

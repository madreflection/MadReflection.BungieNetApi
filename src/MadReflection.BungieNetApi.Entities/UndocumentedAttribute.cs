using System;

namespace BungieNet
{
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public sealed class UndocumentedAttribute : Attribute
	{
		public UndocumentedAttribute()
		{
			Details = "";
		}

		public UndocumentedAttribute(string details)
		{
			Details = details;
		}


		public string Details { get; set; }
	}
}

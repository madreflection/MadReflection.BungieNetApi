﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace BungieNet
{
	internal static class EnumExtensions
	{
		public static object GetUnderlyingValue<TEnum>(this TEnum value)
			where TEnum : struct, Enum
		{
			FieldInfo[] fields = value.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			return fields[0].GetValue(value);
		}

		public static string ToNumericString<TEnum>(this TEnum value) where TEnum : struct, Enum => GetUnderlyingValue(value).ToString();

		public static string ToNumericCsv<TEnum>(this IEnumerable<TEnum> values)
			where TEnum : struct, Enum
		{
			if (values is null)
				throw new ArgumentNullException(nameof(values));

			return string.Join(",", values.Select(v => v.GetUnderlyingValue()));
		}

		public static string ToStringCsv<TEnum>(this IEnumerable<TEnum> values)
			where TEnum : struct, Enum
		{
			if (values is null)
				return "";

			return string.Join(",", values.Select(v => v.ToString()));
		}

		public static bool IsRedirectCode(this HttpStatusCode hsc) => hsc == HttpStatusCode.Moved || hsc == HttpStatusCode.MovedPermanently || hsc == HttpStatusCode.RedirectKeepVerb;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace LibraryGenerator
{
	public static class ExtensionMethods
	{
		public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> pair, out TKey key, out TValue value)
		{
			key = pair.Key;
			value = pair.Value;
		}

		public static IEnumerable<TResult> IsType<TResult>(this IEnumerable source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));

			return IsTypeIterator<TResult>(source, typeof(TResult));
		}

		public static IEnumerable<TResult> IsTypeIterator<TResult>(IEnumerable source, Type targetType)
		{
			foreach (object item in source)
			{
				if (item is TResult && item.GetType() == targetType)
					yield return (TResult)item;
			}
		}

		public static OpenApiDocument Read(this OpenApiStreamReader reader, Stream input)
		{
			if (reader is null)
				throw new ArgumentNullException(nameof(reader));

			return reader.Read(input, out OpenApiDiagnostic _);
		}
	}
}

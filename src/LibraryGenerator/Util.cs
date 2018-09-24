using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryGenerator
{
	public static class Util
	{
		#region private static readonly Dictionary<Type, EnumFieldTypeMetadata> _enumUnderlyingTypes = new Dictionary<Type, EnumFieldTypeMetadata>();
		private static readonly Dictionary<Type, EnumFieldTypeMetadata> _enumUnderlyingTypes = new Dictionary<Type, EnumFieldTypeMetadata>()
		{
			{ typeof(long),   new EnumFieldTypeMetadata("long",   "0x{0:X}", "0x{0:x}") },
			{ typeof(ulong),  new EnumFieldTypeMetadata("ulong",  "0x{0:X}", "0x{0:x}") },
			{ typeof(int),    new EnumFieldTypeMetadata("int",    "0x{0:X}",  "0x{0:x}")  },
			{ typeof(uint),   new EnumFieldTypeMetadata("uint",   "0x{0:X}",  "0x{0:x}")  },
			{ typeof(short),  new EnumFieldTypeMetadata("short",  "0x{0:X}",  "0x{0:x}")  },
			{ typeof(ushort), new EnumFieldTypeMetadata("ushort", "0x{0:X}",  "0x{0:x}")  },
			{ typeof(byte),   new EnumFieldTypeMetadata("byte",   "0x{0:X}",  "0x{0:x}")  },
			{ typeof(sbyte),  new EnumFieldTypeMetadata("sbyte",  "0x{0:X}",  "0x{0:x}")  }
		};
		#endregion

		#region private static readonly Dictionary<Type, string> _keywordedTypes = new Dictionary<Type, string>();
		private static readonly Dictionary<Type, string> _keywordedTypes = new Dictionary<Type, string>()
		{
			{ typeof(bool), "bool" },
			{ typeof(char), "char" },
			{ typeof(sbyte), "sbyte" },
			{ typeof(byte), "byte" },
			{ typeof(short), "short" },
			{ typeof(ushort), "ushort" },
			{ typeof(int), "int" },
			{ typeof(uint), "uint" },
			{ typeof(long), "long" },
			{ typeof(ulong), "ulong" },
			{ typeof(float), "float" },
			{ typeof(double), "double" },
			{ typeof(decimal), "decimal" },
			{ typeof(string), "string" },
			{ typeof(object), "object" },
			{ typeof(void), "void" }
		};
		#endregion


		public static string GetEnumUnderlyingTypeKeyword(Type underlyingType)
		{
			if (underlyingType == null)
				throw new ArgumentNullException(nameof(underlyingType));

			if (underlyingType == typeof(int))
				return "int";
			if (underlyingType == typeof(long))
				return "long";
			if (underlyingType == typeof(short))
				return "short";
			if (underlyingType == typeof(byte))
				return "byte";
			if (underlyingType == typeof(uint))
				return "uint";
			if (underlyingType == typeof(ulong))
				return "ulong";
			if (underlyingType == typeof(ushort))
				return "ushort";
			if (underlyingType == typeof(sbyte))
				return "sbyte";

			throw new ArgumentException("Invalid field type for an enum.", nameof(underlyingType));
			//return "int";
		}

		public static Type GetEnumUnderlyingType(string format)
		{
			switch (format)
			{
				case "byte":
					return typeof(byte);

				case "sbyte":
					return typeof(sbyte);

				case "int16":
					return typeof(short);

				case "uint16":
					return typeof(ushort);

				case "int32":
					return typeof(int);

				case "uint32":
					return typeof(uint);

				case "int64":
					return typeof(long);

				case "uint64":
					return typeof(ulong);

				default:
					return null;
			}
		}

		public static string GetTypeKeyword(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			return _keywordedTypes.TryGetValue(type, out string keyword) ? keyword : null;
		}

		public static string GetSimpleTypeName(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			if (type.Namespace == "System")
				return type.Name;

			return type.FullName;
		}

		public static string GetTypeExpression(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			if (Nullable.GetUnderlyingType(type) is Type underlyingType)
				return GetTypeExpression(underlyingType) + "?";

			return GetTypeKeyword(type) ?? GetSimpleTypeName(type);
		}

		//public static string GetTypeExpression(TypeReference typeReference)
		//{
		//	if (typeReference.Type != null)
		//		return GetTypeExpression(typeReference.Type);

		//	var typeBuilder = typeReference.TypeBuilder;
		//	if (typeBuilder != null)
		//	{
		//		if (typeBuilder is NullableEnumBuilder nullableEnumBuilder)
		//			return nullableEnumBuilder.Name + "?";

		//		return typeBuilder.Name;
		//	}

		//	return "object";
		//}

		public static string FormatHex(object value, bool lowercase = false)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			if (!_enumUnderlyingTypes.TryGetValue(value.GetType(), out EnumFieldTypeMetadata formats))
				throw new ArgumentException("Invalid type.", nameof(value));

			if (lowercase)
				return string.Format(formats.LowerFormat, value);

			return string.Format(formats.UpperFormat, value);
		}

		public static object GetEnumValue(Type type, string numericValue)
		{
			if (!_enumUnderlyingTypes.ContainsKey(type))
				throw new ArgumentException("Not a valid type for enum fields.", nameof(type));

			return Convert.ChangeType(numericValue, type);
		}

		public static string DotNetifyIdentifier(string jsonIdentifier)
		{
			if (string.IsNullOrEmpty(jsonIdentifier))
				throw new ArgumentNullException(nameof(jsonIdentifier));

			return char.ToUpper(jsonIdentifier[0]) + jsonIdentifier.Substring(1);
		}

		public static string SplitTypeName(string schemaName)
		{
			if (schemaName == null)
				throw new ArgumentNullException(nameof(schemaName));

			int dot = schemaName.LastIndexOf('.');
			if (dot < 0)
				return schemaName;

			return schemaName.Substring(dot + 1);
		}

		public static string SplitNamespace(string schemaName)
		{
			if (schemaName == null)
				throw new ArgumentNullException(nameof(schemaName));

			int dot = schemaName.LastIndexOf('.');
			if (dot < 0)
				return "";

			return schemaName.Substring(0, dot);
		}

		public static string JoinName(string @namespace, string typeName)
		{
			if (string.IsNullOrEmpty(@namespace))
				return typeName;

			if (string.IsNullOrEmpty(typeName))
				return @namespace;

			return @namespace + "." + typeName;
		}

		public static string EscapeCSharpString(string value)
		{
			if (value.IndexOf('"') < 0)
				return value;

			StringBuilder sb = new StringBuilder(value);

			sb.Replace("\"", "\\\"");

			return sb.ToString();
		}

		public static string EscapeHtmlString(string value)
		{
			StringBuilder sb = new StringBuilder(value);

			sb.Replace("&", "&amp;");
			sb.Replace("<", "&lt;");
			sb.Replace(">", "&gt;");

			return sb.ToString();
		}
	}
}

using System;
using static LibraryGenerator.Util;

namespace LibraryGenerator
{
	public struct TypeReference
	{
		public static readonly string ComponentsSchemasRootPath = "#/components/schemas/";


		public TypeReference(Type type)
		{
			Type = type ?? throw new ArgumentNullException(nameof(type));
			TypeBuilder = null;
			JsonPath = null;
		}

		public TypeReference(TypeBuilder typeBuilder)
		{
			Type = null;
			TypeBuilder = typeBuilder ?? throw new ArgumentNullException(nameof(typeBuilder));
			JsonPath = null;
		}

		public TypeReference(string jsonPath)
		{
			Type = null;
			TypeBuilder = null;
			JsonPath = jsonPath ?? throw new ArgumentNullException(nameof(jsonPath));

			if (!jsonPath.StartsWith(ComponentsSchemasRootPath))
				throw new ArgumentException("A JSON path to a file must start with the expected prefix.", nameof(jsonPath));
		}


		public Type Type { get; }

		public TypeBuilder TypeBuilder { get; }

		public string JsonPath { get; set; }

		public bool IsType => Type != null;

		public bool IsTypeBuilder => TypeBuilder != null;

		public bool IsJsonPath => JsonPath != null;

		public bool IsValid => Type != null || TypeBuilder != null || JsonPath != null;

		public bool IsArray
		{
			get
			{
				if (Type != null && Type.IsArray)
					return true;

				if (TypeBuilder != null && TypeBuilder is ArrayBuilder)
					return true;

				return false;
			}
		}

		public string Name
		{
			get
			{
				if (Type != null)
					return GetTypeExpression(Type);

				if (TypeBuilder != null)
				{
					if (TypeBuilder is DictionaryBuilder dictionaryBuilder)
						return $"System.Collections.Generic.Dictionary<{dictionaryBuilder.KeyType.Name}, {dictionaryBuilder.ItemType.Name}>";

					if (TypeBuilder is ArrayBuilder arrayBuilder)
						return $"{arrayBuilder.ElementType.Name}[]";

					return TypeBuilder.Name;
				}

				if (JsonPath != null)
					return JsonPath.Substring(ComponentsSchemasRootPath.Length);

				return "object";
			}
		}

		public string QualifiedName
		{
			get
			{
				if (Type != null)
					return GetTypeExpression(Type);

				if (TypeBuilder != null)
				{
					if (TypeBuilder is DictionaryBuilder dictionaryBuilder)
						return $"System.Collections.Generic.Dictionary<{dictionaryBuilder.KeyType.QualifiedName}, {dictionaryBuilder.ItemType.QualifiedName}>";

					if (TypeBuilder is ArrayBuilder arrayBuilder)
						return $"{arrayBuilder.ElementType.QualifiedName}[]";

					if (TypeBuilder is NullableEnumBuilder nullableEnumBuilder)
						return new TypeReference(nullableEnumBuilder.EnumBuilder).QualifiedName + "?";

					if (string.IsNullOrEmpty(TypeBuilder.Namespace))
						return TypeBuilder.Name;

					return TypeBuilder.Namespace + "." + TypeBuilder.Name;
				}

				if (JsonPath != null)
					return JsonPath.Substring(ComponentsSchemasRootPath.Length);

				return "object";
			}
		}


		public static implicit operator TypeReference(Type type) => new TypeReference(type);
		public static implicit operator TypeReference(TypeBuilder typeBuilder) => new TypeReference(typeBuilder);
		public static implicit operator TypeReference(string jsonPath) => new TypeReference(jsonPath);

		public static explicit operator Type(TypeReference typeReference) => typeReference.Type ?? throw new InvalidCastException();
		public static explicit operator TypeBuilder(TypeReference typeReference) => typeReference.TypeBuilder ?? throw new InvalidCastException();
		public static explicit operator string(TypeReference typeReference) => typeReference.JsonPath ?? throw new InvalidCastException();
	}
}

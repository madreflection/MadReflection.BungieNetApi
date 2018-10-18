using Microsoft.OpenApi.Models;

namespace LibraryGenerator
{
	public class ParameterBuilder : Builder
	{
		public BuilderParameterLocation Location { get; set; }

		public TypeReference Type { get; set; }

		public bool IsParams { get; set; }

		public string StringExpression
		{
			get
			{
				TypeReference parameterType = Type;

				if (parameterType.Type != null)
				{
					if (parameterType.Type == typeof(bool))
						return $"{Name}.ToString().ToLower()";

					if (parameterType.Type == typeof(string))
					{
						if (Location == BuilderParameterLocation.Query)
							return $"({Name} ?? \"\")";

						return Name;
					}

					if (!parameterType.Type.IsValueType && Location == BuilderParameterLocation.Query)
						return $"({Name}?.ToString() ?? \"\")";

					return Name + ".ToString()";
				}

				if (parameterType.TypeBuilder is TypeBuilder typeBuilder)
				{
					if (typeBuilder is EnumBuilder enumBuilder)
						return $"(({Util.GetEnumUnderlyingTypeKeyword(enumBuilder.UnderlyingType)}){Name}).ToString()";

					if (typeBuilder is ClassBuilder classBuilder)
					{
						if (Location == BuilderParameterLocation.Query)
							return $"({Name}?.ToString())";

						return $"{Name}.ToString()";
					}

					if (typeBuilder is ArrayBuilder arrayBuilder)
						return $"string.Join(\",\", {Name})";

					throw new System.Exception("What happened?!");
				}

				if (parameterType.JsonPath != null)
					throw new System.Exception("What happened?!");

				throw new System.Exception("What happened?!");
			}
		}
	}
}

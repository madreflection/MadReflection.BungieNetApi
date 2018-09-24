using System;

namespace LibraryGenerator
{
	public abstract class PathSegment
	{
		public abstract string StringExpression { get; }
	}

	public class ConstantPathSegment : PathSegment
	{
		public string Value { get; set; }

		public override string StringExpression => $"\"{Value}\"";
	}

	public class ParameterPathSegment : PathSegment
	{
		public ParameterBuilder Parameter { get; set; }

		public override string StringExpression
		{
			get
			{
				TypeReference parameterType = Parameter.Type;

				if (parameterType.Type != null)
				{
					if (parameterType.Type == typeof(string))
						return Parameter.Name;

					return Parameter.Name + ".ToString()";
				}

				if (parameterType.TypeBuilder is TypeBuilder typeBuilder)
				{
					if (typeBuilder is EnumBuilder enumBuilder)
						return $"(({Util.GetEnumUnderlyingTypeKeyword(enumBuilder.UnderlyingType)}){Parameter.Name}).ToString()";

					if (typeBuilder is ClassBuilder classBuilder)
						return Parameter.Name + ".ToString()";

					throw new Exception("What happened?!");
				}

				if (parameterType.JsonPath != null)
					throw new Exception("What happened?!");

				throw new Exception("What happened?!");
			}
		}
	}
}

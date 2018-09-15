using System.IO;

namespace LibraryGenerator
{
	public abstract class Builder
	{
		public string Name { get; set; }

		public string JsonName { get; set; }

		public string Description { get; set; }


		public virtual void Write(TextWriter writer)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
	public class ArrayBuilder : TypeBuilder
	{
		public TypeReference ElementType { get; set; }
	}
}

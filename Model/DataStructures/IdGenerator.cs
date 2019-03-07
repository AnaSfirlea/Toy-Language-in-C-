using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.Model.DataStructures
{
	class IdGenerator
	{
		static private int id=0;
		public static int generateId()
		{
			id++;
			return id;
		}
	}
}

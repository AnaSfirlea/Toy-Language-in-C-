using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	interface MyIList<E>
	{
		void add(E e);
		E get(int index);
		bool equals(Object o);
		int hashCode();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	interface MyIStack<T>
	{
		T pop();
		void push(T v);
		bool empty();
	}
}

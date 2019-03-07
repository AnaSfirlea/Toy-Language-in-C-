using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	class MyList<E> : MyIList<E>
	{
		private List<E> list;
		public MyList() { this.list = new List<E>(); }

		public void add(E e)
		{
			list.Add(e);
		}

		public bool equals(Object o)
		{
			return list.Equals(o);
		}
		public int hashCode()
		{
			return list.GetHashCode();
		}
		public E get(int index)
		{
			return list.ElementAt(index);
		}
		public override string ToString()
		{
			string res = "";
			for(int i=0;i<this.list.Count();i++)
			{
				res += "\n";
				res += this.list.ElementAt(i).ToString();
			}

			return res;
		}
	}

}

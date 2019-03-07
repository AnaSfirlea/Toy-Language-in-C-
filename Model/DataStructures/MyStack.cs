using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	class MyStack<T> : MyIStack<T>
	{
		private Stack<T> stack;
		public MyStack() { this.stack = new Stack<T>(); }
		public MyStack(Stack<T> stack)
		{
			this.stack = stack;
		}

		public T pop()
		{
			return stack.Pop();
		}

		public void push(T v)
		{
			stack.Push(v);

		}

		public bool empty()
		{
			if (stack.Count() == 0)
				return true;
			return false;
		}
		public override string ToString()
		{
			Stack<T> aux_stack = new Stack<T>(this.stack);
			string res="";
			while(aux_stack.Count()!=0)
			{
				res += "\n";
				res += aux_stack.Pop().ToString();
			}
			return res;
		}
	}
}

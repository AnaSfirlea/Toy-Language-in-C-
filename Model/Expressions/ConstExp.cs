using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;

namespace ToyLanguageCS.Model.Expressions
{
	class ConstExp : Exp
	{
		int number;

		public ConstExp(int number)
		{
			this.number = number;
		}

		public int getNumber()
		{
			return number;
		}

		public void setNumber(int number)
		{
			this.number = number;
		}

		public override string ToString()
		{
			return number.ToString();
		}

		
		public override int eval(MyIDictionary<string, int> tbl)
		{
			return number;
		}

	}
}

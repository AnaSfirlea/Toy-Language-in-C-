using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;

namespace ToyLanguageCS.Model.Expressions
{
	class ArithExp : Exp
	{
		private Exp e1;
		private Exp e2;
		private char op;

		public ArithExp(char op, Exp e1, Exp e2)
		{
			this.e1 = e1;
			this.e2 = e2;
			this.op = op;
		}

		public Exp getE1()
		{
			return e1;
		}

		public void setE1(Exp e1)
		{
			this.e1 = e1;
		}

		public Exp getE2()
		{
			return e2;
		}

		public void setE2(Exp e2)
		{
			this.e2 = e2;
		}

		public int getOp()
		{
			return op;
		}

		public void setOp(char op)
		{
			this.op = op;
		}

		public override string ToString()
		{

			return e1.ToString() + op + e2.ToString();
		}
		public override int eval(MyIDictionary<string, int> tbl)
		{

			if (op == '+')
				return (e1.eval(tbl) + e2.eval(tbl));
			else
				if (op == '-')
				return (e1.eval(tbl) - e2.eval(tbl));
			else
					if (op == '*')
				return (e1.eval(tbl) * e2.eval(tbl));
			else
						if (op == '/')//div by zero exception
			{
				//if (e2.eval(tbl) == 0)
					//throw new MyStmtExecException("Division by zero is not possible!");
			//	else
					return (e1.eval(tbl) / e2.eval(tbl));
			}
			else
							if (op == '%')
				return (e1.eval(tbl) % e2.eval(tbl));
			else
								if (op == '=')
				if (e1.eval(tbl) != e2.eval(tbl))
					return 0;
			return 0;
		}
	}
}

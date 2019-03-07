using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;

namespace ToyLanguageCS.Model.Expressions
{
	class BooleanExp
	{
		private Exp e1;
		private Exp e2;
		private String op;

		public BooleanExp(Exp e1, Exp e2, String op)
		{
			this.e1 = e1;
			this.e2 = e2;
			this.op = op;
		}

		
		public override string ToString()
		{
			return e1.ToString() + op + e2.ToString();
		}

		public int eval(MyIDictionary<string, int> tbl)
		{
			if (op.Equals("<"))
				if (e1.eval(tbl) < e2.eval(tbl))
					return 1;
				else
				if (op.Equals(">"))
					if (e1.eval(tbl) > e2.eval(tbl))
						return 1;
					else
					if (op.Equals("<="))
						if (e1.eval(tbl) <= e2.eval(tbl))
							return 1;
						else
						if (op.Equals(">="))
							if (e1.eval(tbl) >= e2.eval(tbl))
								return 1;
							else
							if (op.Equals("=="))
								if (e1.eval(tbl) == e2.eval(tbl))
									return 1;
								else
								if (op.Equals("!="))
									if (e1.eval(tbl) != e2.eval(tbl))
										return 1;
			return 0;
		}
	}
}

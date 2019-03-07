using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.Model.Expressions;

namespace ToyLanguageCS.Model.Statements
{
	class IfStmt : IStmt
	{
		private Exp exp;
		private IStmt thenS;
		private IStmt elseS;

		public IfStmt(Exp e, IStmt t, IStmt el)
		{
			this.exp = e;
			this.thenS = t;
			this.elseS = el;
		}

		public Exp getExp()
		{
			return exp;
		}

		public void setExp(Exp exp)
		{
			this.exp = exp;
		}

		public IStmt getThenS()
		{
			return thenS;
		}

		public void setThenS(IStmt thenS)
		{
			this.thenS = thenS;
		}

		public IStmt getElseS()
		{
			return elseS;
		}

		public void setElseS(IStmt elseS)
		{
			this.elseS = elseS;
		}


		public override String ToString()
		{

			return "IF(" + exp.ToString() + ")THEN(" + thenS.ToString() + ")" + " ELSE(" + elseS.ToString() + ")";
		}
		public PrgState execute(PrgState state)
		{
			if (exp.eval(state.getSymTable()) != 0)
				thenS.execute(state);
			else
				elseS.execute(state);

			return state;
		}
		public IStmt deepCopy()
		{
			IfStmt copy = new IfStmt(this.exp, this.thenS, this.elseS);
			return copy;
		}
	}
}

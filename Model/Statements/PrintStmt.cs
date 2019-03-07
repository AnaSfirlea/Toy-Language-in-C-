using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.Expressions;

namespace ToyLanguageCS.Model.Statements
{
	class PrintStmt : IStmt
	{
		private Exp exp;

		public PrintStmt(Exp exp)
		{
			this.exp = exp;
		}

		public PrgState execute(PrgState state)
		{

			MyIList<int> ot = state.getOut();
			MyIDictionary<String, int> symTbl = state.getSymTable();
			ot.add(exp.eval(state.getSymTable()));
			return state;
		}

		
		public override String ToString()
		{

			return "print(" + exp.ToString() + ")";
		}

		public IStmt deepCopy()
		{
			PrintStmt copy = new PrintStmt(this.exp);
			return copy;
		}

	}
}

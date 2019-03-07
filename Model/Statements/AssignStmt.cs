using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.Expressions;

namespace ToyLanguageCS.Model.Statements
{
	class AssignStmt : IStmt
	{
		private String id;
		Exp exp;

		public AssignStmt(String id, Exp exp)
		{
			this.id = id;
			this.exp = exp;
		}

		public String getId()
		{
			return id;
		}

		public void setId(String id)
		{
			this.id = id;
		}

		public Exp getExp()
		{
			return exp;
		}

		public void setExp(Exp exp)
		{
			this.exp = exp;
		}

		
		public override String ToString()
		{

			return id + "=" + exp.ToString();
		}

		public PrgState execute(PrgState state)
		{
			MyIStack<IStmt> stk = state.getExeStack();
			MyIDictionary<String, int> symTbl = state.getSymTable();
			try
			{
				int val = exp.eval(symTbl);

				//if (!symTbl.isDefined(this.id))
				//throw new MyStmtExecException("The variable is not assigned");
				//int address = symTbl.get(this.id);
				//heap.put(address, val);

				symTbl.put(this.id, val); //we assign the new values

			}
			catch (Exception ex)
			{
				Console.WriteLine("ASSIGN ERROR");
			}

			return state;
		}

		public IStmt deepCopy()
		{
			AssignStmt copy = new AssignStmt(this.id, this.exp);
			return copy;
		}
	}
}

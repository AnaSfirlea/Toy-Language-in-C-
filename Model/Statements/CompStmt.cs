using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
namespace ToyLanguageCS.Model.Statements
{
	class CompStmt : IStmt
	{
		private IStmt first;
		private IStmt snd;

		public CompStmt(IStmt first, IStmt snd)
		{
			this.first = first;
			this.snd = snd;
		}

		public IStmt getFirst()
		{
			return first;
		}

		public void setFirst(IStmt first)
		{
			this.first = first;
		}

		public IStmt getSnd()
		{
			return snd;
		}

		public void setSnd(IStmt snd)
		{
			this.snd = snd;
		}

		
		public override String ToString()
		{
			return "(" + first.ToString() + ";"+ snd.ToString() + ")";
		}

		public PrgState execute(PrgState state)
		{

			MyIStack<IStmt> stk = state.getExeStack();
			stk.push(snd);
			stk.push(first);
			return state;
		}

		public IStmt deepCopy()
		{

			CompStmt copy = new CompStmt(this.first, this.snd);
			return copy;
		}
	}
}

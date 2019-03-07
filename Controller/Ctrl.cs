using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.Repository;
using ToyLanguageCS.Model;
using ToyLanguageCS.Model.Statements;
using ToyLanguageCS.DataStructures;
using System.IO;

namespace ToyLanguageCS.Controller
{
	class Ctrl
	{
		private IRep repo;
		private int flag;

		public Ctrl(IRep repo, int flag)
		{

			this.repo = repo;
			this.flag = flag;
		}

		public PrgState oneStep(PrgState state)
		{
			MyIStack<IStmt> stk = state.getExeStack();

			try
			{
				if (stk.empty())
					throw new Exception("Empty stack");

				IStmt crtStmt = stk.pop();
				PrgState newState = crtStmt.execute(state);
				if (flag == 1)
					this.displayCrtPrgState(newState);
				//repo.logPrgStateExec();
				return newState;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void allStep()
		{

			PrgState prg = repo.getCrtPrg();
			while (!prg.getExeStack().empty())
			{
				try
				{
					while (true)
					{
						oneStep(prg);
						repo.logPrgStateExec();
					}

				}

				catch (IOException e)
				{
					throw new Exception(e.Message);
				}
				catch (Exception e)
				{
					throw new Exception(e.Message);
				}
			}
		}

		private void displayCrtPrgState(PrgState state)
		{
			Console.Write(state.ToString());
		}

	}
	
}

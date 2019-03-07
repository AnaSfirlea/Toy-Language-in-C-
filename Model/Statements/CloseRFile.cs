using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.Expressions;
using ToyLanguageCS.Model.DataStructures;
using System.IO;

namespace ToyLanguageCS.Model.Statements
{
	class CloseRFile : IStmt
	{
		private Exp exp_file_id;

		public CloseRFile(Exp exp_file_id)
		{
			this.exp_file_id = exp_file_id;
		}

		public PrgState execute(PrgState state)
		{
			MyIStack<IStmt> stk = state.getExeStack();
			// stk.pop();

			MyIDictionary<String, int> symTbl = state.getSymTable();
			IFileTable<int, FileTuple> fileTbl = state.getFileTable();

			int value_exp = this.exp_file_id.eval(symTbl);


			FileTuple ft = fileTbl.getValue(value_exp);

			if (!fileTbl.isDefined(value_exp))
			{
				throw new Exception("The key is not defined in the file table");
			}

			StreamReader streamReader = fileTbl.getValue(value_exp).getStreamReader();

			try
			{
				streamReader.Close();
			}
			catch (IOException ex) { throw new Exception(ex.Message); }

			fileTbl.remove(value_exp);
			return state;

		}
		
		public override String ToString()
		{
			return "CloseRFile(" + this.exp_file_id + ")";
		}

		public IStmt deepCopy()
		{
			return new CloseRFile(this.exp_file_id);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.Expressions;
using ToyLanguageCS.Model.DataStructures;
namespace ToyLanguageCS.Model.Statements
{
	class OpenRFile : IStmt
	{
		private String var_file_id;
		private String filename;

		public OpenRFile(String var_file_id, String filename)
		{
			this.var_file_id = var_file_id;
			this.filename = filename;
		}

		public PrgState execute(PrgState state)
		{
			MyIStack<IStmt> stk = state.getExeStack();
			IFileTable<int, FileTuple> filetable = state.getFileTable();
			MyIDictionary<String, int> symTbl = state.getSymTable();
			try
			{
				FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
				StreamReader bufferedStream = new StreamReader(reader);
				int id = IdGenerator.generateId();
				FileTuple tuple = new FileTuple(this.filename, bufferedStream);
				filetable.put(id, tuple);
				
				symTbl.put(this.var_file_id, id);
			}
			catch (Exception ex) { throw new Exception(ex.Message); }


			return state;
		}

		
		public override string ToString()
		{
			return "OpenRFile(" + this.var_file_id + "," + this.filename + ")";
		}

		public IStmt deepCopy()
		{
			OpenRFile copy = new OpenRFile(this.var_file_id, this.filename);
			return copy;
		}
	}
}

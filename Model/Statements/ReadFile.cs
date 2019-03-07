 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.DataStructures;
using ToyLanguageCS.Model.Expressions;

namespace ToyLanguageCS.Model.Statements
{
	class ReadFile : IStmt
	{
		private Exp exp_file_id;
		private String var_name;

		public ReadFile(Exp exp_file_id, String var_name)
		{
			this.exp_file_id = exp_file_id;
			this.var_name = var_name;
		}

		public Exp getExp_file_id()
		{
			return exp_file_id;
		}

		public void setExp_file_id(Exp exp_file_id)
		{
			this.exp_file_id = exp_file_id;
		}

		public String getVar_name()
		{
			return this.var_name;
		}

		public void setVar_name(String var_name)
		{
			this.var_name = var_name;
		}

		public PrgState execute(PrgState state)
		{
			MyIStack<IStmt> stk = state.getExeStack();
			MyIDictionary<String, int> symTbl = state.getSymTable();
			IFileTable<int, FileTuple> fileTbl = state.getFileTable();
	
			int value_exp = this.exp_file_id.eval(symTbl);

			FileTuple ft = fileTbl.getValue(value_exp);

			if (!symTbl.isDefined(ft.getFileName()))
			{
				//throw new MyStmtExecException("The key is not defined in the file table");
			}
			
			StreamReader streamReader = ft.getStreamReader();
			int val = -1;
			try
			{
				String line = streamReader.ReadLine();

				if (line == null)
				{
					val = 0;
				}
				else try
					{
						val = int.Parse(line);
					}
					catch (Exception ex) { Console.WriteLine(ex.Message); }


				symTbl.put(this.var_name, val);
			}
			catch (IOException ex) { throw new Exception(ex.Message); }
			return state;
		}
		public override string ToString()
		{
			return "ReadFile(" + this.exp_file_id + "," + this.var_name + ")";
		}

		public IStmt deepCopy()
		{
			return new ReadFile(this.exp_file_id, this.var_name);
		}


	}
}

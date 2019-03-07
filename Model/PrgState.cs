using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
using ToyLanguageCS.Model.DataStructures;
using ToyLanguageCS.Model.Expressions;
using ToyLanguageCS.Model.Statements;
namespace ToyLanguageCS.Model
{
	class PrgState
	{
		private MyIStack<IStmt> exeStack;
		private MyIDictionary<string, int> symTable;
		private MyIList<int> outTbl;
		private IFileTable<int, FileTuple> fileTable;
		private IStmt originalProgram;

		public PrgState(MyIStack<IStmt> stk, MyIDictionary<string, int> symtbl,
					MyIList<int> ot, IFileTable<int, FileTuple> fileTable, IStmt prg)
		{
			this.exeStack = stk;
			this.symTable = symtbl;
			this.outTbl = ot;
			this.originalProgram = prg.deepCopy();
			this.fileTable = fileTable;
			this.exeStack.push(prg);
		}
		public PrgState(IStmt prg)
		{
			this.exeStack = new MyStack<IStmt>();
			this.symTable = new MyDictionary<String, int>();
			this.outTbl = new MyList<int>();
			this.originalProgram = prg.deepCopy();
			this.fileTable = new FileTable<int, FileTuple>();
			this.exeStack.push(prg);

		}
		public MyIStack<IStmt> getExeStack()
		{
			return exeStack;
		}

		public void setExeStack(MyIStack<IStmt> exeStack)
		{
			this.exeStack = exeStack;
		}

		public MyIDictionary<string, int> getSymTable()
		{
			return symTable;
		}
		public void setSymTable(MyIDictionary<String, int> symTable)
		{
			this.symTable = symTable;
		}

		public MyIList<int> getOut()
		{
			return outTbl;
		}

		public void setOut(MyIList<int> outTbl)
		{
			this.outTbl = outTbl;
		}
		public IStmt getOriginalProgram()
		{
			return originalProgram;
		}

		public void setOriginalProgram(IStmt originalProgram)
		{
			this.originalProgram = originalProgram;
		}
		public IFileTable<int, FileTuple> getFileTable() { return this.fileTable; }

		public override string ToString()
		{

				return  "ExeStack:" + exeStack.ToString() + "\n" +
						"SymTable:" + symTable.ToString() + "\n" +
						"Out:" + outTbl.ToString()+"\n" +
						"FileTable:" + fileTable.ToString() + "\n" +
						"OriginalProgram:" + originalProgram.ToString() + "\n";
		}
	}
}

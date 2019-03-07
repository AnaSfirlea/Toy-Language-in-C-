using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.Model;
using ToyLanguageCS.DataStructures;
using System.IO;

namespace ToyLanguageCS.Repository
{
	class Rep :IRep
	{
		private MyIList<PrgState> prgStates;
		private PrgState crtPrg;
		private String logFilePath;

		public Rep(MyIList<PrgState> prgStates)
		{
			this.prgStates = prgStates;
			this.crtPrg = prgStates.get(0);
			//this.logFilePath = "/logfile.txt";
			this.logFilePath = "fil.txt";
			//this.logFilePath = "C: /Users/Anamaria - Dell/source/repos/ToyLanguageCS/ToyLanguageCS/logfile.txt";
		}

		public Rep(MyIList<PrgState> prgStates, String filename)
		{
			this.prgStates = prgStates;
			this.crtPrg = prgStates.get(0);
			this.logFilePath = filename;


		}

		public Rep(MyIList<PrgState> prgStates, PrgState crtPrg)
		{
			this.prgStates = prgStates;
			this.crtPrg = crtPrg;
		}

		public String getLogFilePath()
		{
			return logFilePath;
		}

		public PrgState getCrtPrg()
		{
			return this.crtPrg;
		}

		public void add(PrgState state)
		{
			prgStates.add(state);

		}
		public void logPrgStateExec()
		{

			//StreamWriter logFile = new StreamWriter(new StreamWriter(new StreamWriter(path: this.logFilePath, append: true)));
			StreamWriter logFile = new StreamWriter(new BufferedStream(new FileStream(this.logFilePath, FileMode.Open, FileAccess.Write)));
			logFile.Write("ExeStack:");
			logFile.Write("\n");
			logFile.Write(this.crtPrg.getExeStack().ToString());
			logFile.Write("\n");

			logFile.Write("SymTable:");
			logFile.Write("\n");
			logFile.Write(this.crtPrg.getSymTable().ToString());
			logFile.Write("\n");

			logFile.Write("Out:");
			logFile.Write("\n");
			logFile.Write((this.crtPrg.getOut().ToString()));
			logFile.Write("\n");

			logFile.Write("FileTable:");
			logFile.Write("\n");
			logFile.Write(this.crtPrg.getFileTable().ToString());
			logFile.Write("\n");

			logFile.Write("\n");
			logFile.Write("\n");

			logFile.Close();

		}
	}
}

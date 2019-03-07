using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.Model;

namespace ToyLanguageCS.Repository
{
	interface IRep
	{
		PrgState getCrtPrg();
		void logPrgStateExec();
		String getLogFilePath();
	}
}

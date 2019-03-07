using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.Model.Statements
{
	interface IStmt
	{
		PrgState execute(PrgState state);
		IStmt deepCopy();
		string ToString();
	}
}

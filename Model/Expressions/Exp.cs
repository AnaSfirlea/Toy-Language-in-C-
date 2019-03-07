using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
namespace ToyLanguageCS.Model.Expressions
{
	abstract class Exp
	{
		public abstract int eval(MyIDictionary<string, int> tbl);
	}
}

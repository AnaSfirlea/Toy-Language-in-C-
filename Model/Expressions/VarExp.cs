using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;

namespace ToyLanguageCS.Model.Expressions
{
	class VarExp : Exp
	{
		private string id;

		public VarExp(string id)
		{
			this.id = id;
		}

		public string getId()
		{
			return id;
		}

		public void setId(string id)
		{
			this.id = id;
		}

		
		public override string ToString()
		{
			return id;
		}

		public override int eval(MyIDictionary<string, int> tbl)
		{
			//if (!tbl.isDefined(id))
			//	throw new MyStmtExecException("The id is not in the table: Exception thrown from VarExp");

			int val = 0;
			ICollection<string> keys = tbl.keys();
			for(int i=0;i<keys.Count();i++)
			{
				if (keys.ElementAt(i) == this.id)
				{
					val = tbl.get(i);
					break;
				}
			}
			return val;

		}
	}
}

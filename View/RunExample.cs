using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.Controller;

namespace ToyLanguageCS.View
{
	class RunExample : Command
	{
		private Ctrl ctrl;
		public RunExample(String key, String description, Ctrl ctrl) : base(key, description)
		{
			this.ctrl = ctrl;
		}

		public override void execute()
		{
			try
			{
				ctrl.allStep();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

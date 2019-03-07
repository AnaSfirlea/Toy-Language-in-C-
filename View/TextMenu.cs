using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyLanguageCS.DataStructures;
namespace ToyLanguageCS.View
{
	class TextMenu
	{
		private MyIDictionary<String, Command> commands;

		public TextMenu()
		{
			this.commands = new MyDictionary<string, Command>();
		}

		public void addCommand(Command c)
		{
			commands.put(c.getKey(), c);
		}

		private void printMenu()
		{
			for (int i=0;i< commands.size();i++)
			{
				Command c = commands.values().ElementAt(i);
				String line = String.Format("{0} :{1,1}", c.getKey(), c.getDescription());
				Console.WriteLine(line);
			}

		}
		public void show()
		{
			while (true)
			{
				printMenu();
				Console.WriteLine("Input the option: ");
				String key = Console.ReadLine();
				Command com = commands.getValue(key);
				if (com == null)
				{
					Console.WriteLine("Invalid Option");
					continue;
				}
				com.execute();
			}
		}

	}
}

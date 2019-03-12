using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.View.Menu
{
    public class TextMenu
    {
        private Dictionary<string, Command> commands;

        public TextMenu()
        {
            commands = new Dictionary<string, Command>();
        }

        public void AddCommand(Command c)
        {
            commands[c.GetKey()] = c;
        }

        private void PrintMenu()
        {
            foreach (Command com in commands.Values)
            {
                string line = string.Format(com.GetKey() + " " + com.GetDescription());
                System.Console.WriteLine(line);
            }
        }

        public void Show()
        {

            while (true)
            {
                PrintMenu();
                System.Console.WriteLine("Input the option: ");

                string key = Console.ReadLine();

                Command com = commands[key];
                if (com == null)
                {
                    System.Console.WriteLine("Invalid Option");
                    continue;
                }
                com.Execute();
            }
        }
    }
}

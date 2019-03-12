using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.View.Menu
{
    public class ExitCommand : Command
    {
        public ExitCommand(string key, string desc) 
            : base(key, desc) { }


        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}

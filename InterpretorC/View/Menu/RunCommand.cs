using System;

namespace InterpretorC.View.Menu
{
    public class RunCommand : Command
    {
        private Controller.Controller ctrl;
        public RunCommand(string key, string desc, Controller.Controller ctr) : base(key, desc)
        {
            this.ctrl = ctr;
        }

        public override void Execute()
        {

            try
            {
                ctrl.AllSteps();
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

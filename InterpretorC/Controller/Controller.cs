
using System.Collections.Generic;
using System.Text;
using InterpretorC.Repository;
using InterpretorC.Utils;
using InterpretorC.Statements;
using System;

namespace InterpretorC.Controller
{
    public class Controller
    {
        private IRepository repo;

        public Controller(IRepository repo)
        {
            this.repo = repo;
        }

 
        public PrgState OneStep(PrgState state)
        {
            IMyStack<IStatement> stack = state.Stack;
            if(!(stack.IsEmpty()))
            { 
                IStatement statement = stack.Pop();
                return statement.Execute(state);
            }
            return null;
           
        }

        public void AllSteps()
        {
            PrgState prg = repo.GetCurrentPrg();
            while(!(prg.Stack.IsEmpty()))
            {
                OneStep(prg);
                repo.LogPrgStateExec(prg);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}

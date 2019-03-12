using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.Statements
{
    public class CompStatement: IStatement
    {
        private IStatement first;
        private IStatement second;

        public CompStatement(IStatement first, IStatement second)
        {
            this.first = first;
            this.second = second;
        }

        public PrgState Execute(PrgState state)
        {
            state.Stack.Push(second);
            state.Stack.Push(first);
            return state;
        }

        public override string ToString()
        {
            return "[" + first + ";" + second + "]";
        }


    }
}

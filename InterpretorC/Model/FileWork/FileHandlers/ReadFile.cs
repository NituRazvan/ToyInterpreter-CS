using System;
using System.IO;
using InterpretorC.Statements;
using InterpretorC.Expressions;

namespace InterpretorC.FileWork.FileHandlers
{
    public class ReadFile : IStatement
    {
        private IExpression expID;
        private string newVarName;

        public ReadFile(IExpression expId, string newVarName)
        {
            expID = expId;
            this.newVarName = newVarName;
        }


        public PrgState Execute(PrgState state)
        {
            int id = expID.Eval(state.Dict);
            StreamReader sw = state.FileTable.Get(id).S1;

            string line = sw.ReadLine();
            if (line == "")
                throw new SystemException("Can't read the line");


            int value = int.Parse(line);

            state.Dict.SetValue(newVarName, value);

            return state;

        }

        public override string ToString()
        {
            return "ReadFile(" + newVarName + ")";
        }
    }
}

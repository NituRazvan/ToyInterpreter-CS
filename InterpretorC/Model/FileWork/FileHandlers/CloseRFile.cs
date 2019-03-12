using System;
using InterpretorC.Statements;
using InterpretorC.Expressions;

namespace InterpretorC.FileWork.FileHandlers
{
    public class CloseRFile : IStatement
    {
        private IExpression exp;

        public CloseRFile(IExpression exp)
        {
            this.exp = exp;
        }

        public PrgState Execute(PrgState state)
        {
            int id = exp.Eval(state.Dict);

            if (!state.FileTable.Exists(id))
                throw new SystemException("This file" + exp + "can't be closed because do not exist");

            state.FileTable.Get(id).S1.Close();
            state.FileTable.Delete(id);

            return state;
        }

        public override string ToString()
        {
            return "Close(" + exp + ")";
        }
    }
}

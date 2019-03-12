using InterpretorC.Expressions;

namespace InterpretorC.Statements
{
    public class IfStatement : IStatement
    {
        private IStatement thenS;
        private IStatement elseS;
        private IExpression exp;

        public IfStatement(IExpression exp, IStatement thenS, IStatement elseS)
        {
            this.thenS = thenS;
            this.elseS = elseS;
            this.exp = exp;
        }

        public PrgState Execute(PrgState state)
        {
            if (exp.Eval(state.Dict) != 0)
                state.Stack.Push(thenS);
            else
                state.Stack.Push(elseS);

            return state;

        }

        public override string ToString()
        {
            return "IF(" + exp + ") THEN(" + thenS + ")ELSE(" + elseS + ")";
        }
    }
}

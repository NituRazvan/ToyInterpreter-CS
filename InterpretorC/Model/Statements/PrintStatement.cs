using InterpretorC.Expressions;

namespace InterpretorC.Statements
{

    public class PrintStatement : IStatement
    {
        private IExpression exp;

        public PrintStatement(IExpression exp)
        {
            this.exp = exp;
        }

        public PrgState Execute(PrgState state)
        {

            int result = exp.Eval(state.Dict);
            state.OutList.Add(result);

            return state;
        }

        public override string ToString()
        {
            return "Print(" + exp + ")";
        }
    }
}

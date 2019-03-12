using InterpretorC.Expressions;

namespace InterpretorC.Statements
{
    public class AssignStatement : IStatement
    {
        private IExpression exp;
        private string id;

        public AssignStatement(IExpression exp, string id)
        {
            this.exp = exp;
            this.id = id;
        }

        public PrgState Execute(PrgState state)
        {

            int result = exp.Eval(state.Dict);
            state.Dict.SetValue(id, result);

            return state;

        }

        public override string ToString()
        {
            return "Assign(" + id + "=" + exp + ")";
        }
    }
}

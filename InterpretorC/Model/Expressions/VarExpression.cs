using System;
using InterpretorC.Utils;

namespace InterpretorC.Expressions
{
    public class VarExpression : IExpression
    {
        private String id;

        public VarExpression(string id)
        {
            this.id = id;
        }

        public int Eval(IMyDict<string, int> dict)
        {
            return dict.GetValue(id);
        }

        public override string ToString()
        {
            return id;
        }
    }
}

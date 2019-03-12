using System;
using InterpretorC.Utils;

namespace InterpretorC.Expressions
{
    public class ArithExpression : IExpression
    {
        private IExpression st;
        private IExpression dr;
        private char op;

        public ArithExpression(IExpression st, IExpression dr, char op)
        {
            this.st = st;
            this.dr = dr;
            this.op = op;
       
        }


        public int Eval(IMyDict<string, int> dict)
        {
            int vst = st.Eval(dict);
            int vdr = dr.Eval(dict);

            if (op == '+')
                return vst + vdr;
            if (op == '-')
                return vst - vdr;
            if (op == '*')
                return vst * vdr;
            else
            {
                if (vdr == 0)
                    throw new DivideByZeroException();
                else
                    return vst / vdr;
            }
        }

        public override string ToString()
        {
            return "" + st + op + dr;
        }




    }
}

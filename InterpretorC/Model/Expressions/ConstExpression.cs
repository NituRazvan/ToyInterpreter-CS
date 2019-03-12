using InterpretorC.Utils;

namespace InterpretorC.Expressions
{
    public class ConstExpression : IExpression
    {
        private int number;

        public ConstExpression(int number)
        {
            this.number = number;
        }


        public int Eval(IMyDict<string, int> dict)
        {
            return number;
        }

        public override string ToString()
        {
            return " " + number;
        }
    }
}

using System;
using InterpretorC.Utils;

namespace InterpretorC.Expressions
{
    public interface IExpression
    {
       int Eval(IMyDict<String, int> dict);

    }
}

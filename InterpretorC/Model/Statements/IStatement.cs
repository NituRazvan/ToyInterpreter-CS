using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.Statements
{
    public interface IStatement
    {
        PrgState Execute(PrgState state);

    }
}

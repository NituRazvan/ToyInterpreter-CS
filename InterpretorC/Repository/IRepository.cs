using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.Repository
{
    public interface IRepository
    {
        void AddProg(PrgState prg);
        void LogPrgStateExec(PrgState state);
        PrgState GetCurrentPrg();
    }
}

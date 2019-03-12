using System;
using System.IO;
using InterpretorC.Statements;

namespace InterpretorC.FileWork.FileHandlers
{
    public class OpenRFile : IStatement
    {
        private string varName;
        private string fname;
        private static int id = 0;

        public OpenRFile(string varName, string fname)
        {
            this.varName = varName;
            this.fname = fname;
        }

        public PrgState Execute(PrgState state)
        {
            foreach (FileData i in state.FileTable.AllValues())
                if (i.Name == fname)
                    throw new SystemException("this file " + fname + " is already opened");

            if (!File.Exists(fname))
                throw new SystemException("this file " + fname + " can't be found");


            StreamReader sw = new StreamReader(fname, true);
            state.FileTable.Add(id, new FileData(fname, sw));
            state.Dict.SetValue(varName, id++);

            return state;

        }

        public override string ToString()
        {
            return "Open(" + fname + ")";

        }
    }
}
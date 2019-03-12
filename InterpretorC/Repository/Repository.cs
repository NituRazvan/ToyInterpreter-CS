using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using InterpretorC.FileWork;
namespace InterpretorC.Repository
{
    public class Repository: IRepository
    {
        private List<PrgState> elements = new List<PrgState>();
        private int current = 0;
        public void AddProg(PrgState x)
        {
            elements.Add(x);
        }
        public PrgState GetCurrentPrg()
        {
            return elements[current];
        }
        public void LogPrgStateExec(PrgState state)
        {
            using (StreamWriter sw = File.AppendText("../../../iesire.txt"))
            {
                sw.WriteLine("\nStack: ");
                foreach (var i in state.Stack)
                {
                    sw.WriteLine(i);
                }

                sw.WriteLine("\nDict: ");
                foreach (KeyValuePair<string, int> kvp in state.Dict)
                {
                    sw.WriteLine(kvp.Key + " --> " + kvp.Value);
                }

                sw.WriteLine("\nOutput: ");
                foreach (var i in state.OutList)
                {
                    sw.WriteLine(i);
                }

                sw.WriteLine("\nFileTable: ");
                foreach (KeyValuePair<int, FileData> kvp in state.FileTable)
                {
                    sw.WriteLine(kvp.Key + " --> " + kvp.Value.Name);
                }

                sw.WriteLine("\n");
            }
            Console.WriteLine("\nStack: ");
            foreach (var i in state.Stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nDict: ");
            foreach (KeyValuePair<string, int> kvp in state.Dict)
            {
                Console.WriteLine(kvp.Key + " --> " + kvp.Value);
            }

            Console.WriteLine("\nOutput: ");
            foreach (var i in state.OutList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFileTable: ");
            foreach (KeyValuePair<int, FileData> kvp in state.FileTable)
            {
                Console.WriteLine(kvp.Key + " --> " + kvp.Value.Name);
            }

            Console.WriteLine("\n");
        }
    }
}

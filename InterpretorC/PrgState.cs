using InterpretorC.Utils;
using InterpretorC.Statements;
using InterpretorC.FileWork;

namespace InterpretorC
{
    public class PrgState
    {
        private IMyDict<string, int> dict;
        private IMyStack<IStatement> stack;
        private IMyList<int> outList;
        private FileTable<int, FileData> fileTable;

        public PrgState(IMyDict<string, int> dict, IMyStack<IStatement> stack, IMyList<int> outList, FileTable<int, FileData> fileTable)
        {
            this.dict = dict;
            this.stack = stack;
            this.outList = outList;
            this.fileTable = fileTable;
        }
        public IMyDict<string, int> Dict
        {
            get { return dict; }
            set { dict = value; }
        }

        public IMyStack<IStatement> Stack
        {
            get { return stack; }
            set { stack = value; }
        }

        public IMyList<int> OutList
        {
            get { return outList; }
            set { outList = value; }
        }

        public FileTable<int, FileData> FileTable
        {
            get { return fileTable; }
            set { fileTable = value; }
        }
       
    }
}

using System.IO;

namespace InterpretorC.FileWork
{
    public class FileData
    {
        private string name;
        private StreamReader S;

        public FileData(string name, StreamReader S)
        {
            this.name = name;
            this.S = S;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public StreamReader S1
        {
            get { return S; }
            set { S = value; }
        }
    }
}

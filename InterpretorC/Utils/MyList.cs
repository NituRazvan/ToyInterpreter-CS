using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.Utils
{
    public class MyList<T>: IMyList<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T x)
        {
            elements.Add(x);
        }

        public void Remove(T x)
        {
            elements.Remove(x);
        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder bld = new StringBuilder();

            foreach (T i in elements)
            {
                bld.Append(i).Append(" ");
            }
            return bld.ToString();
        }
    }
}

using System;
using System.Collections;
using System.Text;

namespace InterpretorC.Utils
{
    public interface IMyList<T> : IEnumerable 
    {
        void Add(T x);

        void Remove(T x);

    }
}
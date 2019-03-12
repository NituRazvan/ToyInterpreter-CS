using System.Collections;

namespace InterpretorC.Utils
{
    public interface IMyStack<T> : IEnumerable
    {
        void Push(T x);
        T Pop();
        bool IsEmpty();
    }
}

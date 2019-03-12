using System.Collections;
using System.Collections.Generic;

namespace InterpretorC.Utils
{
    public class MyStack<T> : IMyStack<T>
    {
        private Stack<T> stack = new Stack<T>();

        public void Push(T x)
        {
            stack.Push(x);
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public IEnumerator GetEnumerator()
        {
            return stack.GetEnumerator();
        }
    }
}


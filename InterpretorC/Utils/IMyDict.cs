using System;
using System.Collections;
using System.Text;

namespace InterpretorC.Utils
{
    public interface IMyDict <K,V> : IEnumerable
    {
        bool Exists(K key);
        V GetValue(K key);
        void SetValue(K key, V value);
        void UpdateValue(K key, V value);
    }
}

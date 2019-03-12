using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InterpretorC.Utils
{
    public class MyDict<K, V> : IMyDict<K, V>
    {
        private Dictionary<K, V> dict = new Dictionary<K, V>();

        public bool Exists(K key)
        {
            return dict.ContainsKey(key);
        }

        public V GetValue(K key)
        {
            return dict[key];
        }

        public void SetValue(K key, V value)
        {
            dict[key] = value;
        }

        public void UpdateValue(K key, V value)
        {
            dict[key] = value;
        }


        public IEnumerator GetEnumerator()
        {
            return dict.GetEnumerator();
        }

    }
}

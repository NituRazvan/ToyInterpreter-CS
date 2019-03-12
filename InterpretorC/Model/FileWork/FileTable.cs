using System.Collections;
using System.Collections.Generic;


namespace InterpretorC.FileWork
{
    public class FileTable<K, V> : IEnumerable
    {
        Dictionary<K, V> fileTable = new Dictionary<K, V>();

        public void Add(K key, V value)
        {
            fileTable[key] = value;
        }

        public void Delete(K key)
        {
            fileTable.Remove(key);
        }

        public bool Exists(K key)
        {
            return fileTable.ContainsKey(key);
        }

        public V Get(K key)
        {
            return fileTable[key];
        }

        public void Update(K key, V value)
        {
            fileTable[key] = value;
        }

        public bool ContainsKey(K key)
        {
            return fileTable.ContainsKey(key);
        }

        public bool ContainsValue(V value)
        {
            return fileTable.ContainsValue(value);
        }

        public IEnumerable AllValues()
        {
            return fileTable.Values;
        }

        public IEnumerator GetEnumerator()
        {
            return fileTable.GetEnumerator();
        }
    }
}

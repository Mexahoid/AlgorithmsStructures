using Structures.List;
using Structures.Interfaces;


namespace Structures.Dictionary
{
    public class MyDictionary<K, V>
    {
        private readonly MyArrayList<K> _keys;
        private readonly MyArrayList<V> _values;

        public MyDictionary()
        {
            _keys = new MyArrayList<K>();
            _values = new MyArrayList<V>();
        }

        public bool ContainsKey(K key)
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                if (_keys[i].Equals(key))
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            _keys.Clear();
            _values.Clear();
        }

        public bool ContainsValue(V value)
        {
            for (int i = 0; i < _values.Count; i++)
            {
                if (_values[i].Equals(value))
                    return true;
            }
            return false;
        }

        public K GetKeyByValue(V value)
        {
            for (int i = 0; i < _values.Count; i++)
            {
                if (_values[i].Equals(value))
                    return _keys[i];
            }
            return default;
        }

        public void RemoveByKey(K key)
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                if (_keys[i].Equals(key))
                {
                    _keys.RemoveAt(i);
                    _values.RemoveAt(i);
                    return;
                }
            }
        }

        public IMyList<K> GetKeys()
        {
            MyLinkedList<K> list = new();
            for (int i = 0; i < _keys.Count;i++)
            {
                list.Add(_keys[i]);
            }
            return list;
        }

        public void RemoveByValue(V value)
        {
            int count = _values.Count;
            for (int i = 0; i < count; i++)
            {
                if (_values[i].Equals(value))
                {
                    _keys.RemoveAt(i);
                    _values.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        public V this[K key] 
        {
            get
            {
                for (int i = 0; i < _keys.Count; i++)
                {
                    if (_keys[i].Equals(key))
                    {
                        return _values[i];
                    }
                }
                return default;
            }
            set
            {
                for (int i = 0; i < _keys.Count; i++)
                {
                    if (_keys[i].Equals(key))
                    {
                        _values[i] = value;
                        return;
                    }
                }

                _keys.Add(key);
                _values.Add(value);
            }
        }
    }
}

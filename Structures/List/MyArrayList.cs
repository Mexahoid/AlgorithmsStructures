using Structures.Interfaces;

namespace Structures.List
{
    public class MyArrayList<T> : IMyList<T>
    {
        private readonly int _size;
        private int _ptr;
        private T[] _array;

        public MyArrayList(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException(nameof(size));
            _size = size;
            _ptr = 0;
            _array = new T[size];
        }

        public T this[int index] { get => _array[index]; set => _array[index] = value; }

        public int Count => _ptr;

        public void Add(T input)
        {
            _array[_ptr++] = input;

            if (_ptr >= _array.Length)
            {
                ResizeArray(true);
            }
        }

        public void Clear()
        {
            _array = new T[_size];
            _ptr = 0;
        }

        private void ResizeArray(bool increase)
        {
            T[] newArray;
            int count;
            int newSize;
            if (increase)
            {
                newSize = _array.Length + _size;
                count = _array.Length;
            }
            else
            {
                newSize = _array.Length - _size;
                count = newSize;
            }
            newArray = new T[newSize];
            for (int i = 0; i < count; i++)
                newArray[i] = _array[i];
            _array = newArray;
        }

        public void Remove(T value)
        {
            int i;
            for (i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(value))
                    break;
            }
            RemoveAt(i);
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _array.Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            _ptr--;

            if (_ptr < _array.Length - _size)
            {
                ResizeArray(false);
            }
        }
    }
}

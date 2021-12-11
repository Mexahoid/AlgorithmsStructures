using Structures.Interfaces;

namespace Structures.Stack
{
    public class MyArrayStack<T> : IMyStack<T>
    {
        private int _ptr;
        private T[] _array;
        private readonly int _size;

        public MyArrayStack(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException(nameof(size));
            _size = size;
            _array = new T[size];
            _ptr = 0;
        }

        public bool IsEmpty => _ptr == 0;

        public T Peek()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();
            return _array[_ptr - 1];
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


        public T Pop()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();
            _ptr--;
            T ret = _array[_ptr];

            if (_ptr < _array.Length - _size)
            {
                ResizeArray(false);
            }

            return ret;
        }

        public void Push(T item)
        {
            _array[_ptr++] = item;
            if (_ptr >= _array.Length)
            {
                ResizeArray(true);
            }
        }
    }
}

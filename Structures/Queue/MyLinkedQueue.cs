using Structures.Interfaces;
using Structures.Common;

namespace Structures.Queue
{
    public class MyLinkedQueue<T> : IMyQueue<T>
    {
        private INode<T> _head;
        private INode<T> _tail;

        public MyLinkedQueue()
        {
            _head = null;
            _tail = null;
        }

        public bool IsEmpty => _head == null;

        public T Dequeue()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();

            T ret = _head.Value;

            _head = _head.Next;

            return ret;
        }

        public void Enqueue(T item)
        {
            SimpleNode<T> node = new(item);
            if (IsEmpty)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();

            return _head.Value;
        }
    }
}

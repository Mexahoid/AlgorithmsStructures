using Structures.Common;
using Structures.Interfaces;

namespace Structures.Queue
{
    public class MyDeque<T> : MyLinkedQueue<T>
    {
        public MyDeque() : base()
        {

        }

        public T DequeueTail()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();
            INode<T> node = _head;

            if (node.Next == null)
            {
                return Dequeue();
            }

            while (node.Next.Next != null)
            {
                node = node.Next;
            }

            T ret = node.Next.Value;
            node.Next = null;
            _tail = node;

            return ret;
        }

        public void EnqueueHead(T item)
        {
            INode<T> node = new SimpleNode<T>(item);

            if (IsEmpty)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }
        }

        public T PeekTail()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException();
            return _tail.Value;
        }
    }
}

using Structures.Interfaces;
using Structures.Common;

namespace Structures.List
{
    public class MyLinkedList<T> : IMyList<T>
    {
        private INode<T> _head;
        private int _count;

        public int Count { get => _count; }

        public MyLinkedList()
        {
            _head = null;
            _count = 0;
        }

        public void Add(T input)
        {
            SimpleNode<T> node = new(input);
            node.Next = _head;
            _head = node;
            _count++;
        }


        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                _head = _head.Next;
                _count--;
                return;
            }

            INode<T> node = _head;
            int i = _count - 1;

            while (i > index + 1)
            {
                node = node.Next;
                i--;
            }
            node.Next = node.Next.Next;
            _count--;
        }


        public void Remove(T value)
        {
            INode<T> node = _head;

            if (node.Value.Equals(value))
            {
                _head = _head.Next;
                _count--;
                return;
            }

            while (node.Next != null)
            {
                if (node.Next.Value.Equals(value))
                {
                    node.Next = node.Next.Next;
                    _count--;
                    return;
                }
                node = node.Next;
            }
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public T this[int index] { 
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();

                INode<T> node = _head;
                int i = _count - 1;

                while (i > index)
                {
                    node = node.Next;
                    i--;
                }
                return node.Value;
            }

            set
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();

                INode<T> node = _head;
                int i = _count - 1;

                while (i > index)
                {
                    node = node.Next;
                    i--;
                }
                node.Value = value;
            }
        }
    }
}

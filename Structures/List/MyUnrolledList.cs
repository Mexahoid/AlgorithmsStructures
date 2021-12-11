using Structures.Interfaces;
using Structures.Common;

namespace Structures.List
{
    public class MyUnrolledList<T> : IMyList<T>
    {
        private readonly int _size;
        private int _count;
        private UnrolledNode<T[]> _head;

        public MyUnrolledList(int size)
        {
            _size = size;
            _head = null;
        }

        public T this[int index] 
        {
            get
            {
                int i = _count - 1;
                UnrolledNode<T[]> ptr = _head;

                while (ptr != null)
                {
                    for (int j = ptr.Count - 1; j >= 0; j--)
                    {
                        if (i == index)
                        {
                            return ptr.Value[j];
                        }
                        i--;
                    }
                    ptr = (UnrolledNode<T[]>)ptr.Next;
                }
                return default;
            } 
            set
            {
                int i = _count - 1;
                UnrolledNode<T[]> ptr = _head;

                while (ptr != null)
                {
                    for (int j = ptr.Count - 1; j >= 0; j--)
                    {
                        if (i == index)
                        {
                            ptr.Value[j] = value;
                        }
                        i--;
                    }
                    ptr = (UnrolledNode<T[]>)ptr.Next;
                }
            }
        }

        public int Count => _count;

        public void Add(T input)
        {
            _count++;
            if (_head == null)
            {
                UnrolledNode<T[]> tnode = new(new T[_size]);
                tnode.Value[tnode.Count++] = input;
                _head = tnode;
                return;
            }
            UnrolledNode<T[]> ptr = _head;
            while (ptr != null)
            {
                if (ptr.Count < _size)
                {
                    ptr.Value[ptr.Count++] = input;
                    return;
                }
                ptr = (UnrolledNode<T[]>)ptr.Next;
            }

            UnrolledNode<T[]> node = new(new T[_size]);
            node.Value[node.Count++] = input;
            node.Next = _head;
            _head = node;
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        private void NodeRemoveAt(UnrolledNode<T[]> node, int index)
        {
            int j = 0;
            for (; j < _size - 1; j++)
                node.Value[j] = node.Value[j + 1];
            node.Value[j] = default;
            node.Count--;
        }

        private void ClearNodes()
        {
            if (_head == null)
                return;

            if (_head.Count == 0)
                _head = (UnrolledNode<T[]>)_head.Next;

            if (_head == null)
                return;

            UnrolledNode<T[]> ptr = _head;
            while (ptr != null && ptr.Next != null)
            {
                if (((UnrolledNode<T[]>)ptr.Next).Count == 0)
                    ptr.Next = ptr.Next.Next;
                ptr = (UnrolledNode<T[]>)ptr.Next;
            }
        }

        public void Remove(T value)
        {
            _count--;
            UnrolledNode<T[]> ptr = _head;

            while (ptr != null)
            {
                for (int j = ptr.Count - 1; j >= 0; j--)
                {
                    if (ptr.Value[j].Equals(value))
                    {
                        NodeRemoveAt(ptr, j);
                        ClearNodes();
                        return;
                    }
                }
                ptr = (UnrolledNode<T[]>)ptr.Next;
            }
        }

        public void RemoveAt(int index)
        {
            int i = _count - 1;
            _count--;
            UnrolledNode<T[]> ptr = _head;

            while (ptr != null)
            {
                for (int j = ptr.Count - 1; j >= 0; j--)
                {
                    if (i == index)
                    {
                        NodeRemoveAt(ptr, j);
                        ClearNodes();
                        return;
                    }
                    i--;
                }
                ptr = (UnrolledNode<T[]>)ptr.Next;
            }
        }
    }
}

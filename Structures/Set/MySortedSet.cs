using Structures.Interfaces;
using Structures.Common;

namespace Structures.Set
{
    public class MySortedSet<T> : IMySet<T> where T : IComparable<T>
    {
        private int _count;
        private INode<T> _head;
        public int Count => _count;

        public bool Add(T value)
        {
            if (_head == null)
            {
                _head = new SimpleNode<T>(value);
                _count++;
                return true;
            }

            int cmp = _head.Value.CompareTo(value);
            if (cmp >= 0)
            {
                if (cmp == 0)
                    return false;

                INode<T> head = new SimpleNode<T>(value)
                {
                    Next = _head
                };
                _head = head;
                _count++;
                return true;
            }

            INode<T> ptr = _head;

            INode<T> node;
            while (ptr.Next != null)
            {
                cmp = ptr.Next.Value.CompareTo(value);
                if (cmp == 0)
                    return false;
                if (cmp < 0 && (ptr.Next.Next == null || ptr.Next.Next.Value.CompareTo(value) > 0))
                {
                    _count++;
                    node = new SimpleNode<T>(value);
                    node.Next = ptr.Next.Next;
                    ptr.Next.Next = node;
                    return true;
                }
                if (cmp > 0)
                {
                    _count++;
                    node = new SimpleNode<T>(value);
                    node.Next = ptr.Next;
                    ptr.Next = node;
                    return true;
                }
                ptr = ptr.Next;
            }
            _count++;
            node = new SimpleNode<T>(value);
            ptr.Next = node;
            return true;
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public bool Contains(T value)
        {
            INode<T> ptr = _head;
            while (ptr != null)
            {
                if (ptr.Value.Equals(value))
                    return true;
                ptr = ptr.Next;
            }
            return false;
        }

        public void CopyTo(T[] array)
        {
            CopyTo(array, _count);
            /*if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (array.Length < _count)
                throw new ArgumentOutOfRangeException();
            INode<T> ptr = _head;
            int pointer = 0;

            while (ptr != null)
            {
                array[pointer++] = ptr.Value;
                ptr = ptr.Next;
            }*/
        }

        public void CopyTo(T[] array, int amount)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (array.Length < _count)
                throw new ArgumentOutOfRangeException();

            INode<T> ptr = _head;
            int pointer = 0;

            while (ptr != null && pointer < amount)
            {
                array[pointer++] = ptr.Value;
                ptr = ptr.Next;
            }
        }

        public bool Remove(T value)
        {
            INode<T> ptr = _head;
            if (ptr.Value.Equals(value))
            {
                _head = _head.Next;
                _count--;
                return true;
            }

            while (ptr.Next != null)
            {
                if (ptr.Next.Value.Equals(value))
                {
                    ptr.Next = ptr.Next.Next;
                    _count--;
                    return true;
                }
                ptr = ptr.Next;
            }
            return false;
        }
    }
}

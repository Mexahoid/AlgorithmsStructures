﻿
using Structures.Interfaces;
using Structures.Common;

namespace Structures.Stack
{
    public class MyLinkedStack<T> : IMyStack<T>
    {
        private INode<T> _head;

        public MyLinkedStack()
        {
            _head = null;
        }

        public bool IsEmpty => _head == null;

        public T Peek()
        {
            return _head.Value;
        }

        public T Pop()
        {
            T ret = _head.Value;
            _head = _head.Next;
            return ret;
        }

        public void Push(T item)
        {
            SimpleNode<T> node = new(item);
            node.Next = _head;
            _head = node;
        }
    }
}

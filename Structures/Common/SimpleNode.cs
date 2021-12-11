using Structures.Interfaces;

namespace Structures.Common
{
    internal class SimpleNode<T> : INode<T>
    {
        public T Value { get; set; }

        public INode<T> Next { get; set; }

        public SimpleNode(T input)
        {
            Value = input;
            Next = null;
        }
    }
}

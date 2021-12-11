namespace Structures.Common
{
    internal class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T input)
        {
            Value = input;
            Next = null;
        }
    }
}

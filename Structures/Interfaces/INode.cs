
namespace Structures.Interfaces
{
    internal interface INode<T>
    {
        public T Value { get; set; }

        public INode<T> Next { get; set; }
    }
}

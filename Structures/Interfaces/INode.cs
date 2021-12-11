
namespace Structures.Interfaces
{
    public interface INode<T>
    {
        public T Value { get; set; }

        public INode<T> Next { get; set; }
    }
}

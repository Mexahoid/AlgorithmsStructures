
namespace Structures.Interfaces
{
    public interface IMyStack<T>
    {
        public bool IsEmpty { get;}

        public T Pop();

        public void Push(T item);

        public T Peek();
    }
}

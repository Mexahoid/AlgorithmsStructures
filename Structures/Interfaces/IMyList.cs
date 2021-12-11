
namespace Structures.Interfaces
{
    public interface IMyList<T> : ICountable
    {
        public void Add(T input);

        public void Clear();

        public void RemoveAt(int index);

        public void Remove(T value);

        public T this[int index] { get; set; }
    }
}

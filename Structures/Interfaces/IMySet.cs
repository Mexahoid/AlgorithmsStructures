namespace Structures.Interfaces
{
    public interface IMySet<T>
    {
        public bool Add(T value);

        public bool Remove(T value);

        public int Count { get; }

        public bool Contains(T value);

        public void Clear();

        public void CopyTo(T[] array);

        public void CopyTo(T[] array, int amount);
    }
}

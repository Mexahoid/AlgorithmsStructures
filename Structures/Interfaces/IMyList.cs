using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces
{
    public interface IMyList<T>
    {
        public int Count { get; }

        public void Add(T input);

        public void Clear();

        public void RemoveAt(int index);

        public void Remove(T value);

        public T this[int index] { get; set; }
    }
}

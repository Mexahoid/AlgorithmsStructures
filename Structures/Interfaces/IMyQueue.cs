using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces
{
    internal interface IMyQueue<T>
    {
        public bool IsEmpty { get; }

        public void Enqueue(T item);

        public void Enqueue(IEnumerable<T> items);

        public T Dequeue();
    }
}

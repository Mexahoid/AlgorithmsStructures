using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces
{
    public interface IMyQueue<T>
    {
        public bool IsEmpty { get; }

        public void Enqueue(T item);

        public T Dequeue();

        public T Peek();
    }
}

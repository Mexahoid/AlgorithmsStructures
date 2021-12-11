using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Common
{
    internal class UnrolledNode<T> : INode<T>
    {
        public T Value { get; set; }

        public INode<T> Next { get; set; }

        public int Count { get; set; }

        public UnrolledNode(T input)
        {
            Value = input;
            Next = null;
            Count = 0;
        }
    }
}

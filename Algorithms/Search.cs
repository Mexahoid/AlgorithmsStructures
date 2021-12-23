using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Search<T> where T : IComparable<T>
    {
        public static int LinearSearch(IList<T> input, T element, ref int steps)
        {
            for (int i = 0; i < input.Count; i++)
            {
                steps++;
                if (input[i].Equals(element))
                    return i;
            }
            return -1;
        }
    }
}

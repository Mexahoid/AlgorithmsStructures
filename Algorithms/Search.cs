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

        public static int BinarySearch(IList<T> input, T element, ref int steps)
        {
            int left = 0;
            int right = input.Count - 1;



            while(true)
            {
                steps++;
                if (element.CompareTo(input[(left + right) / 2]) > 0)
                    left = (left + right) / 2;
                else
                    right = (left + right) / 2;
                if (input[left].Equals(element))
                    return left;
                if (input[right].Equals(element))
                    return right;

                if (left == right)
                    return -1;
            }
        }
    }
}

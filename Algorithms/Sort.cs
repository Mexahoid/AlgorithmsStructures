namespace Algorithms
{
    public static class Sort<T> where T : IComparable<T>
    {
        public static void BubbleSort(IList<T> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i; j < input.Count; j++)
                {
                    if (input[i].CompareTo(input[j]) > 0)
                    {
                        var ie = input[i];
                        input[i] = input[j];
                        input[j] = ie;
                    }
                }
            }
        }
    }
}
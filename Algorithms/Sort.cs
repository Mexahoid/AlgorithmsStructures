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

        public static void MergeSort(IList<T> input)
        {
            HelpMerge(input, 0, input.Count - 1);
        }

        private static void HelpMerge(IList<T> input, int left, int right)
        {
            if (right - left > 1)
            {
                int middle = (right - left) / 2 + left;
                HelpMerge(input, left, middle);
                HelpMerge(input, middle + 1, right);

                for (int i = left; i < right; i++)
                {
                    var mv = input[i];
                    var mi = i;

                    for (int j = i + 1; j <= right; j++)
                    {
                        if (mv.CompareTo(input[j]) > 0)
                        {
                            mv = input[j];
                            mi = j;
                        }
                    }

                    if (mi != i)
                    {
                        var t = input[mi];
                        input[mi] = input[i];
                        input[i] = t;
                    }
                }
            }
            else
            if (right - left > 0)
            {
                int xx = input[left].CompareTo(input[right]);
                if (xx < 0)
                    return;
                var t = input[left];
                input[left] = input[right];
                input[right] = t;   
            }
        }


        public static void QuickSort(IList<T> input)
        {
            HelpQuick(input, 0, input.Count - 1);
        }

        private static void HelpQuick(IList<T> input, int left, int right)
        {
            if (left < right)
            {
                int pivot = HelpQuickPartition(input, left, right);
                HelpQuick(input, left, pivot);
                HelpQuick(input, pivot + 1, right);
            }
        }

        private static int HelpQuickPartition(IList<T> input, int left, int right)
        {
            T pivot = input[(left + right) / 2];
            int i = left;
            int j = right;

            while(true)
            {
                while (input[i].CompareTo(pivot) < 0)
                    i++;
                while (input[j].CompareTo(pivot) > 0)
                    j--;
                if (i >= j)
                    return j;

                var t = input[j];
                input[j] = input[i];
                input[i] = t;
                i++;
                j--;
            }
        }

    }
}
namespace Ex3
{
    class ArraySort2 : ArraySort
    {
        public override int[] Sort(int[] arrNum)
        {
            int[] vs = (int[])arrNum.Clone();
            QuickSort(vs, 0, vs.Length - 1);
            return vs;
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            int i, j, s;
            if (left < right)
            {
                i = left - 1;
                j = right + 1;
                s = arr[(i + j) / 2];
                while (true)
                {
                    while (arr[++i] < s) ;
                    while (arr[--j] > s) ;
                    if (i >= j)
                        break;
                    Swap(ref arr[i], ref arr[j]);
                }
                QuickSort(arr, left, i - 1);
                QuickSort(arr, j + 1, right);
            }
        }

        private static void Swap(ref int left, ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}


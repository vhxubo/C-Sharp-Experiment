namespace Ex2
{
    class ArraySort
    {
        public int[] Sort(int[] vs)
        {
            int n = vs.Length - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (vs[j + 1] < vs[j])
                    {
                        int temp = vs[j];
                        vs[j] = vs[j + 1];
                        vs[j + 1] = temp;
                    }
                }
            }
            return vs;
        }
    }
}

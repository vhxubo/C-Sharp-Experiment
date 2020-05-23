namespace Ex3
{
    class ArraySort1 : ArraySort
    {
        public override int[] Sort(int[] arrNum)
        {
            int[] vs = (int[])arrNum.Clone();
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

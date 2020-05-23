using System;

namespace Ex2
{
    class ArraySort
    {
        // 初始化数组
        public int[] Init()
        {
            Console.WriteLine("请在下方输入需要排序的数组，格式为：1,2,6,3,5,4 \n请使用英文符号！");

            // 处理输入的数组
            string temp = Console.ReadLine();
            Array arr = temp.Split(',');

            int[] arrNum = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrNum[i] = Convert.ToInt32(arr.GetValue(i));
            }
            return arrNum;
        }

        // 数组排序
        public void Sort(int[] vs)
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
        }

        // 格式化输出排序结果
        public void Output(int[] arrNum)
        {
            Console.Write("Output: ");
            for (int j = 0; j < arrNum.Length; j++)
            {
                Console.Write(arrNum[j]);
                if (j != arrNum.Length - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

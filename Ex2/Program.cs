using System;

/*
 编写一个排序类，实现如下功能：
接收用户输入的数字数组；
对数组进行排序；
输出排序结果。
     */

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请在下方输入需要排序的数组，格式为：1,2,6,3,5,4 \n请使用英文符号！");

            // 处理输入的数组
            ArraySort arrSort = new ArraySort();
            string temp = Console.ReadLine();
            Array arr = temp.Split(',');

            int[] arrNum = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrNum[i] = Convert.ToInt32(arr.GetValue(i));
            }

            // 数组排序
            arrSort.Sort(ref arrNum);

            // 格式化输出排序结果
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
            Console.ReadKey();
        }
    }
}

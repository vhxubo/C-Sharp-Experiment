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
            ArraySort arrSort = new ArraySort();
            int[] arrNum = arrSort.Init();
            arrSort.Sort(arrNum);
            arrSort.Output(arrNum);
            Console.ReadKey();
        }
    }
}

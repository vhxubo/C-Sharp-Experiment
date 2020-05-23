using System;

/*
 编写一个抽象排序类，定义排序方法，接收一个数组，返回排序后的数组并输出：
定义两个对抽象类的继承类，实现两种不同的排序方法；
在主函数中分别调用两个类的方法对数组进行排序； 
*/

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = Init();

            ArraySort1 arrSort1 = new ArraySort1();
            int[] result1 = arrSort1.Sort(arrNum);
            Output("ArraySort1", result1);

            ArraySort2 arrSort2 = new ArraySort2();
            int[] result2 = arrSort2.Sort(arrNum);
            Output("ArraySort2", result2);

            Console.ReadKey();
        }

        static int[] Init()
        {
            Console.WriteLine("请在下方输入需要排序的数组，格式为：1,2,6,3,5,4 \n请使用英文符号！");
            string temp = Console.ReadLine();
            Array arr = temp.Split(',');
            int[] arrNum = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrNum[i] = Convert.ToInt32(arr.GetValue(i));
            }
            return arrNum;
        }

        static void Output(string name, int[] arrNum)
        {
            Console.Write(name + " output: ");
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

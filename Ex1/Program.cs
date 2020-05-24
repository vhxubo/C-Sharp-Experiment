using System;

/*
编写一个随机数小游戏，实现如下功能：
随机生成一个数字；
接受用户输入，并判断是否正确；
给出相应提示；
直到猜对为止。
    */

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int question = random.Next(0, 101);
            int answer = 0;
            Console.WriteLine("亲爱的玩家，请在下方输入一个 [0,100] 的整数，Guess it！");
            do
            {
                Console.Write("你的答案：");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (!Guess(answer, question));
        }

        // 判断用户输入与正确答案是否一致，输出结果
        static bool Guess(int answer, int question)
        {
            if (answer == question)
            {
                Console.WriteLine("--- 恭喜你，答对了！---");
                Console.ReadKey();
                return true;
            }
            else if (answer < question)
            {
                Console.WriteLine("--- 猜小了 ---");
            }
            else
            {
                Console.WriteLine("--- 猜大了 ---");
            }
            return false;
        }
    }
}

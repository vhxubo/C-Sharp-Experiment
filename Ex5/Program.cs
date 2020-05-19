using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 编写一个窗体版随机数小游戏，实现如下功能：
随机生成一个数字；
用文本框接受用户输入，并判断是否正确；
用label给出相应提示；
直到猜对为止，弹出游戏结束对话框。
     */

namespace Ex5
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

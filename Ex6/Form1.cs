﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        private int answer;
        private string PATH = "result.txt";
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (!File.Exists(PATH))
            {
                FileStream fileStream = File.Create(PATH);
                fileStream.Close();

                answer = new Random().Next(0, 101);

                using (StreamWriter sw = new StreamWriter(PATH))
                {
                    sw.Write(answer.ToString());
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(PATH))
                {
                    answer = Convert.ToInt32(sr.ReadLine());
                    sr.Close();
                }
            }

            lb_result.Text = "请输入一个[0,100]的整数";
            tb_guess.Text = "";
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(tb_guess.Text);
            }
            catch
            {
                MessageBox.Show(this, "请输入 [0,100] 的整数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (result < 0 || result > 100)
            {
                MessageBox.Show(this, "请输入 [0,100] 的整数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (answer == result)
            {
                DialogResult dialogResult = MessageBox.Show(this, "恭喜你猜对了！\n再来一局？\n", "游戏结束", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                File.Delete(PATH);

                if (dialogResult == DialogResult.OK)
                {
                    Init();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else if (answer < result)
            {
                lb_result.Text = "猜大了";
            }
            else
            {
                lb_result.Text = "猜小了";
            }
        }
    }
}

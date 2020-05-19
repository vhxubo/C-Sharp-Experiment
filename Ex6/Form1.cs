﻿using System;
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
            try
            {
                answer = Convert.ToInt32(System.IO.File.ReadAllText(PATH));
            }
            catch
            {
                answer = new Random().Next(0, 101);
            }
            lb_result.Text = "请输入一个[0,100]的整数";
            tb_guess.Text = "";
            System.IO.File.WriteAllText(PATH, answer.ToString());
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            int result;
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
                System.IO.File.WriteAllText(PATH, "");
                if (dialogResult == DialogResult.OK)
                {
                    this.Init();
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

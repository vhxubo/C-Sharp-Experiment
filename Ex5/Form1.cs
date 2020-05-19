using System;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        private int answer = new Random().Next(0, 101);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text == "")
            {
                MessageBox.Show(this, "请输入 [0,100] 的整数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = Convert.ToInt32(tb_guess.Text);
            if (result < 0 || result > 100)
            {
                MessageBox.Show(this, "请输入 [0,100] 的整数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (result == answer)
            {
                MessageBox.Show(this, "恭喜你猜对了", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (result < answer)
            {
                lb_result.Text = "猜小了";
            }
            else
            {
                lb_result.Text = "猜大了";
            }
        }
    }
}

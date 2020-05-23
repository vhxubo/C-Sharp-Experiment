using System;
using System.IO;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {

        private string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                Stream fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                textBox1.Text = fileContent;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请先输入文字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (filePath.Equals(string.Empty))
                {
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        filePath = saveFileDialog1.FileName;
                    }
                }
                if (!filePath.Equals(string.Empty))
                {
                    using (StreamWriter file = new StreamWriter(filePath))
                    {
                        foreach (string line in textBox1.Lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                }
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                if (!filePath.Equals(string.Empty))
                {
                    using (StreamWriter file = new StreamWriter(filePath))
                    {
                        foreach (string line in textBox1.Lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}

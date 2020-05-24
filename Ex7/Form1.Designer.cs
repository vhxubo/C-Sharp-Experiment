namespace Ex7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mitem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mitem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mitem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mitem_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitem_file});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mitem_file
            // 
            this.mitem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitem_new,
            this.mitem_open,
            this.toolStripSeparator1,
            this.mitem_save,
            this.mitem_saveas});
            this.mitem_file.Name = "mitem_file";
            this.mitem_file.Size = new System.Drawing.Size(56, 27);
            this.mitem_file.Text = "文件";
            // 
            // mitem_new
            // 
            this.mitem_new.Name = "mitem_new";
            this.mitem_new.Size = new System.Drawing.Size(137, 28);
            this.mitem_new.Text = "新建";
            this.mitem_new.Click += new System.EventHandler(this.mitem_new_Click);
            // 
            // mitem_open
            // 
            this.mitem_open.Name = "mitem_open";
            this.mitem_open.Size = new System.Drawing.Size(137, 28);
            this.mitem_open.Text = "打开";
            this.mitem_open.Click += new System.EventHandler(this.mitem_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // mitem_save
            // 
            this.mitem_save.Name = "mitem_save";
            this.mitem_save.Size = new System.Drawing.Size(137, 28);
            this.mitem_save.Text = "保存";
            this.mitem_save.Click += new System.EventHandler(this.mitem_save_Click);
            // 
            // mitem_saveas
            // 
            this.mitem_saveas.Name = "mitem_saveas";
            this.mitem_saveas.Size = new System.Drawing.Size(137, 28);
            this.mitem_saveas.Text = "另存为";
            this.mitem_saveas.Click += new System.EventHandler(this.mitem_saveas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(782, 520);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简单记事本";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitem_file;
        private System.Windows.Forms.ToolStripMenuItem mitem_new;
        private System.Windows.Forms.ToolStripMenuItem mitem_open;
        private System.Windows.Forms.ToolStripMenuItem mitem_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mitem_saveas;
    }
}


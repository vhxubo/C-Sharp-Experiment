namespace Ex6
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
            this.btn_guess = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_guess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_guess
            // 
            this.btn_guess.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_guess.Location = new System.Drawing.Point(81, 140);
            this.btn_guess.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(165, 62);
            this.btn_guess.TabIndex = 0;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // lb_result
            // 
            this.lb_result.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_result.Location = new System.Drawing.Point(12, 24);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(318, 29);
            this.lb_result.TabIndex = 1;
            this.lb_result.Text = "请输入一个[0,100]的整数";
            this.lb_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_guess
            // 
            this.tb_guess.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_guess.Location = new System.Drawing.Point(30, 70);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(278, 34);
            this.tb_guess.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 213);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_guess);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜数字 Pro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_guess;
    }
}


namespace 学生管理系统
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPWD = new System.Windows.Forms.TextBox();
            this.ForgetLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(83, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(206, 21);
            this.tbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "  用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "登陆密码：";
            // 
            // tbPWD
            // 
            this.tbPWD.Location = new System.Drawing.Point(83, 52);
            this.tbPWD.Name = "tbPWD";
            this.tbPWD.PasswordChar = '*';
            this.tbPWD.Size = new System.Drawing.Size(206, 21);
            this.tbPWD.TabIndex = 4;
            // 
            // ForgetLabel
            // 
            this.ForgetLabel.AutoSize = true;
            this.ForgetLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetLabel.Location = new System.Drawing.Point(57, 126);
            this.ForgetLabel.Name = "ForgetLabel";
            this.ForgetLabel.Size = new System.Drawing.Size(65, 12);
            this.ForgetLabel.TabIndex = 5;
            this.ForgetLabel.Text = "忘记密码？";
            this.ForgetLabel.Click += new System.EventHandler(this.ForgetLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员",
            "教师",
            "学生"});
            this.comboBox1.Location = new System.Drawing.Point(37, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "登陆角色";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 147);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ForgetLabel);
            this.Controls.Add(this.tbPWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPWD;
        private System.Windows.Forms.Label ForgetLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


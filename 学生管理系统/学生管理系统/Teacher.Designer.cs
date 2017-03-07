namespace 学生管理系统
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAchievement = new System.Windows.Forms.TextBox();
            this.btAddAchievement = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbCheckPWD = new System.Windows.Forms.TextBox();
            this.tbNewPWD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbForePWD = new System.Windows.Forms.TextBox();
            this.btSUpdatePWD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "您教授的课程如下";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择您课程的学生如下";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(169, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(135, 232);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "成绩";
            // 
            // tbAchievement
            // 
            this.tbAchievement.Location = new System.Drawing.Point(382, 6);
            this.tbAchievement.Name = "tbAchievement";
            this.tbAchievement.Size = new System.Drawing.Size(100, 21);
            this.tbAchievement.TabIndex = 5;
            // 
            // btAddAchievement
            // 
            this.btAddAchievement.Location = new System.Drawing.Point(497, 4);
            this.btAddAchievement.Name = "btAddAchievement";
            this.btAddAchievement.Size = new System.Drawing.Size(75, 23);
            this.btAddAchievement.TabIndex = 6;
            this.btAddAchievement.Text = "提交";
            this.btAddAchievement.UseVisualStyleBackColor = true;
            this.btAddAchievement.Click += new System.EventHandler(this.btAddAchievement_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(336, 36);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInfo.Size = new System.Drawing.Size(236, 232);
            this.tbInfo.TabIndex = 7;
            // 
            // tbCheckPWD
            // 
            this.tbCheckPWD.Location = new System.Drawing.Point(293, 322);
            this.tbCheckPWD.Name = "tbCheckPWD";
            this.tbCheckPWD.PasswordChar = '*';
            this.tbCheckPWD.Size = new System.Drawing.Size(140, 21);
            this.tbCheckPWD.TabIndex = 14;
            // 
            // tbNewPWD
            // 
            this.tbNewPWD.Location = new System.Drawing.Point(293, 295);
            this.tbNewPWD.Name = "tbNewPWD";
            this.tbNewPWD.PasswordChar = '*';
            this.tbNewPWD.Size = new System.Drawing.Size(140, 21);
            this.tbNewPWD.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "确认新密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "新密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "原密码：";
            // 
            // tbForePWD
            // 
            this.tbForePWD.Location = new System.Drawing.Point(65, 313);
            this.tbForePWD.Name = "tbForePWD";
            this.tbForePWD.PasswordChar = '*';
            this.tbForePWD.Size = new System.Drawing.Size(128, 21);
            this.tbForePWD.TabIndex = 9;
            // 
            // btSUpdatePWD
            // 
            this.btSUpdatePWD.Location = new System.Drawing.Point(467, 299);
            this.btSUpdatePWD.Name = "btSUpdatePWD";
            this.btSUpdatePWD.Size = new System.Drawing.Size(76, 44);
            this.btSUpdatePWD.TabIndex = 8;
            this.btSUpdatePWD.Text = "提交";
            this.btSUpdatePWD.UseVisualStyleBackColor = true;
            this.btSUpdatePWD.Click += new System.EventHandler(this.btSUpdatePWD_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 364);
            this.Controls.Add(this.tbCheckPWD);
            this.Controls.Add(this.tbNewPWD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbForePWD);
            this.Controls.Add(this.btSUpdatePWD);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btAddAchievement);
            this.Controls.Add(this.tbAchievement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Teacher_FormClosing);
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAchievement;
        private System.Windows.Forms.Button btAddAchievement;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbCheckPWD;
        private System.Windows.Forms.TextBox tbNewPWD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbForePWD;
        private System.Windows.Forms.Button btSUpdatePWD;
    }
}
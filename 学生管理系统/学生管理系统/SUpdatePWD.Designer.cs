namespace 学生管理系统
{
    partial class SUpdatePWD
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
            this.btSUpdatePWD = new System.Windows.Forms.Button();
            this.tbForePWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPWD = new System.Windows.Forms.TextBox();
            this.tbCheckPWD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSUpdatePWD
            // 
            this.btSUpdatePWD.Location = new System.Drawing.Point(114, 125);
            this.btSUpdatePWD.Name = "btSUpdatePWD";
            this.btSUpdatePWD.Size = new System.Drawing.Size(75, 23);
            this.btSUpdatePWD.TabIndex = 0;
            this.btSUpdatePWD.Text = "提交";
            this.btSUpdatePWD.UseVisualStyleBackColor = true;
            this.btSUpdatePWD.Click += new System.EventHandler(this.btSUpdatePWD_Click);
            // 
            // tbForePWD
            // 
            this.tbForePWD.Location = new System.Drawing.Point(133, 21);
            this.tbForePWD.Name = "tbForePWD";
            this.tbForePWD.PasswordChar = '*';
            this.tbForePWD.Size = new System.Drawing.Size(140, 21);
            this.tbForePWD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认新密码：";
            // 
            // tbNewPWD
            // 
            this.tbNewPWD.Location = new System.Drawing.Point(133, 51);
            this.tbNewPWD.Name = "tbNewPWD";
            this.tbNewPWD.PasswordChar = '*';
            this.tbNewPWD.Size = new System.Drawing.Size(140, 21);
            this.tbNewPWD.TabIndex = 5;
            // 
            // tbCheckPWD
            // 
            this.tbCheckPWD.Location = new System.Drawing.Point(133, 81);
            this.tbCheckPWD.Name = "tbCheckPWD";
            this.tbCheckPWD.PasswordChar = '*';
            this.tbCheckPWD.Size = new System.Drawing.Size(140, 21);
            this.tbCheckPWD.TabIndex = 6;
            // 
            // SUpdatePWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 160);
            this.Controls.Add(this.tbCheckPWD);
            this.Controls.Add(this.tbNewPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbForePWD);
            this.Controls.Add(this.btSUpdatePWD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SUpdatePWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SUpdatePWD";
            this.Load += new System.EventHandler(this.SUpdatePWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSUpdatePWD;
        private System.Windows.Forms.TextBox tbForePWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPWD;
        private System.Windows.Forms.TextBox tbCheckPWD;
    }
}
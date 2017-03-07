using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace 学生管理系统
{
    public partial class SUpdatePWD : Form
    {
        String id = null;
        public SUpdatePWD()
        {
            InitializeComponent();
        }

        private void btSUpdatePWD_Click(object sender, EventArgs e)
        {
            DBControl ADB = new DBControl();
            SqlDataReader gForePWD = ADB.linkQuery("select Password from Student where [ID]="+id+";");
            gForePWD.Read();
            String forePWD = gForePWD.GetString(0);
            gForePWD.Close();
            //MessageBox.Show(forePWD + "\n" + tbForePWD.Text);
            
            if (tbNewPWD.Text.Equals(tbCheckPWD.Text))
            {
                if (tbForePWD.Text.Trim().Equals(forePWD))
                {
                    if (tbNewPWD.Text.Equals(tbForePWD.Text))
                    {
                        MessageBox.Show("不能与原密码相同！");
                    }
                    else
                    {
                        ADB.linkUpdate("update Student set [Password]='" + tbNewPWD.Text + "' where [ID]="+id+";");
                        MessageBox.Show("更改成功！");
                    }
                }
                else
                {
                    MessageBox.Show("请正确输入原密码！");
                }
            }
            else
            {
                MessageBox.Show("密码确认框输入不一致！");
            }

            ADB.Close();
        }

        private void SUpdatePWD_Load(object sender, EventArgs e)
        {
            String path = Application.StartupPath + "\\temp.txt";
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                if ((id = sr.ReadLine()) == null)
                {
                    MessageBox.Show("文件读取失败！");
                }
                //id = sr.ReadLine();
                sr.Close();
            }
            else
            {
                MessageBox.Show("找不到该文件！" + path);
            }
        }
        
    }
}

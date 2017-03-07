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
    public partial class Login : Form
    {
        String s = null;
        int m = 1;
        private String path =Application.StartupPath+ "\\temp.txt";
        public Login()
        {
            InitializeComponent();
        }

        private void ForgetLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请移步至教务处联系本系统管理员！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                setSQL();
                DBControl ldb = new DBControl();
                SqlDataReader checkAdmin = ldb.linkQuery(s);
                if (checkAdmin.Read())
                {
                    this.Hide();
                    MessageBox.Show("欢迎使用学生管理系统！");
                    if (m == 1)
                    {
                        setIDInfo(checkAdmin.GetValue(0).ToString());
                        Administrator oa = new Administrator();
                        oa.Show();

                    }
                    else if (m == 2)
                    {
                        setIDInfo(checkAdmin.GetValue(0).ToString());
                        Student os = new Student();
                        os.Show();

                    }
                    else if (m == 3)
                    {
                        setIDInfo(checkAdmin.GetValue(0).ToString());
                        Teacher ot = new Teacher();
                        ot.Show();

                    }
                }
                else
                {
                    MessageBox.Show("登陆失败，请检查您的数据");
                }
                ldb.Close();
            }
            else
            {
                MessageBox.Show("您必须选择登陆角色！");
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void setIDInfo(String s)
        {
            //File.Create(path);
            StreamWriter sw = File.CreateText(path);
            sw.WriteLine(s);
            sw.Close();
        }
        private void setSQL()
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "管理员" :
                    s="Select * from admin where [ID]="+tbID.Text+" and [Password]='"+tbPWD.Text+"';";
                    m = 1;
                    break;
                case "学生":
                    s="Select * from Student where [ID]=" + tbID.Text + " and [Password]='" + tbPWD.Text + "';";
                    m = 2;
                    break;
                case "教师":
                    s = "Select * from Teacher where [ID]=" + tbID.Text + " and [Password]='" + tbPWD.Text + "';";
                    m = 3;
                    break;
                default:
                    s="Select * from admin where [ID]="+tbID.Text+" and [Password]='"+tbPWD.Text+"';";
                    m = 1;
                    break;
            }
        }
    }
}

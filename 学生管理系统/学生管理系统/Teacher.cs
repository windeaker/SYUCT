using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace 学生管理系统
{
    public partial class Teacher : Form
    {
        string s;
        String id = null;
        private String path = Application.StartupPath + "\\temp.txt";
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
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
            intialListBox();
            this.tbAchievement.Enabled = false;
            this.btAddAchievement.Enabled = false;
        }
        private void intialListBox()
        {
            DBControl TDB = new DBControl();
            String sql1 = "select Course.ID,Course.Name from Course,Teaching where Course.ID=Teaching.CourseID AND TeachID="+id+";";
            String sql2 = "select Student.Name,Student.ID FROM Student,Teaching where Student.ID=Teaching.StuID AND TeachID=" + id + ";";
            SqlDataReader getCourse = TDB.linkQuery(sql1);
            while (getCourse.Read())
            {
                listBox1.Items.Add(getCourse.GetValue(1).ToString() + "*" + getCourse.GetValue(0).ToString());

            }
            getCourse.Close();
            SqlDataReader getStudent = TDB.linkQuery(sql2);
            s = "";
            while (getStudent.Read())
            {
                if (s != getStudent.GetValue(0).ToString() + "*" + getStudent.GetValue(1).ToString())
                {
                    listBox2.Items.Add(getStudent.GetValue(0).ToString() + "*" + getStudent.GetValue(1).ToString());
                }
                s = getStudent.GetValue(0).ToString() + "*" + getStudent.GetValue(1).ToString();
            }
            getStudent.Close();
            TDB.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInfo.Clear();
            String[] temp = listBox1.SelectedItem.ToString().Split('*');
            DBControl TDB = new DBControl();
            String sql1 = "select * from Course where ID="+temp[1]+";";
            SqlDataReader getCourseInfo = TDB.linkQuery(sql1);
            while (getCourseInfo.Read())
            {
                tbInfo.AppendText("课程ID："+getCourseInfo.GetValue(0).ToString() +"\n");
                tbInfo.AppendText("课程名：" + getCourseInfo.GetValue(1).ToString() + "\n");
                tbInfo.AppendText("课程学分：" + getCourseInfo.GetValue(2).ToString() + "\n");
                tbInfo.AppendText("课程备注：" + getCourseInfo.GetValue(3).ToString() + "\n");
            }
            getCourseInfo.Close();
            listBox2.Items.Clear();
            String sql2 = "select Student.Name,Student.ID FROM Student,Teaching where Student.ID=Teaching.StuID AND CourseID="+temp[1]+";";
            SqlDataReader getStudentList = TDB.linkQuery(sql2);
            while (getStudentList.Read())
            {
                listBox2.Items.Add(getStudentList.GetValue(0).ToString() + "*" + getStudentList.GetValue(1).ToString());
            }
            getStudentList.Close();
            TDB.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] temp = listBox2.SelectedItem.ToString().Split('*');
            DBControl TDB = new DBControl();
            if (listBox1.SelectedItem != null)
            {
                tbInfo.Clear();
                String[] temp1 = listBox1.SelectedItem.ToString().Split('*');
                String Info = "select Student.*,Teaching.* FROM Student,Teaching where Student.ID=Teaching.StuID AND CourseID=" + temp1[1] + " and StuID="+temp[1]+";";
                SqlDataReader getInfo = TDB.linkQuery(Info);
                while (getInfo.Read())
                {
                    tbInfo.AppendText("学号：" + getInfo.GetValue(0).ToString() + "\n");
                    tbInfo.AppendText("姓名：" + getInfo.GetValue(1).ToString() + "\n");
                    tbInfo.AppendText("性别：" + getInfo.GetValue(2).ToString() + "\n");
                    tbInfo.AppendText("学院：" + getInfo.GetValue(3).ToString() + "\n");
                    tbInfo.AppendText("班级：" + getInfo.GetValue(4).ToString() + "\n");
                    tbInfo.AppendText("专业：" + getInfo.GetValue(5).ToString() + "\n");
                    tbInfo.AppendText("课程名：" + temp1[0] + "\n");
                    tbInfo.AppendText("课程名：" + temp1[1] + "\n");
                    tbAchievement.Text = getInfo.GetValue(10).ToString();
                    tbInfo.AppendText("上课地点：" + getInfo.GetValue(11).ToString() + "\n");
                    tbInfo.AppendText("上课时间：" + getInfo.GetValue(12).ToString() + "\n");
                    tbInfo.AppendText("备注：" + getInfo.GetValue(13).ToString() + "\n");
                }
                getInfo.Close();
                this.tbAchievement.Enabled = true;
                this.btAddAchievement.Enabled = true;
            }
            else
            {
                MessageBox.Show("您没有选择科目，将为您显示所有关于→_→" + temp[0] + "←_←的信息！");
                tbInfo.Clear();
                String sqlAll = "select * FROM Student where ID="+temp[1]+";";
                SqlDataReader getAll = TDB.linkQuery(sqlAll);
                while (getAll.Read())
                {
                    tbInfo.AppendText("学号：" + getAll.GetValue(0).ToString() + "\n");
                    tbInfo.AppendText("姓名：" + getAll.GetValue(1).ToString() + "\n");
                    tbInfo.AppendText("性别：" + getAll.GetValue(2).ToString() + "\n");
                    tbInfo.AppendText("学院：" + getAll.GetValue(3).ToString() + "\n");
                    tbInfo.AppendText("班级：" + getAll.GetValue(4).ToString() + "\n");
                    tbInfo.AppendText("专业：" + getAll.GetValue(5).ToString() + "\n");
                }
                getAll.Close();

            }
            TDB.Close();
        }

        private void btAddAchievement_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null&&tbAchievement.Text!=null)
            {
                String[] temp = listBox2.SelectedItem.ToString().Split('*');
                String[] temp1 = listBox1.SelectedItem.ToString().Split('*');
                DBControl TDB = new DBControl();
                TDB.linkUpdate("update Teaching set [Achievement]='" + tbAchievement.Text + "' where [StuID]=" + temp[1] + " and [CourseID]=" + temp1[1] + ";");
                MessageBox.Show("更新成功！");
                TDB.Close();
                this.tbAchievement.Enabled = false;
                this.btAddAchievement.Enabled = false;
            }
            else
            {
                MessageBox.Show("请先选择科目与姓名");
            }
        }

        private void btSUpdatePWD_Click(object sender, EventArgs e)
        {
            if (tbForePWD.Text != null && tbNewPWD.Text != null && tbCheckPWD != null)
            {
                DBControl ADB = new DBControl();
                SqlDataReader gForePWD = ADB.linkQuery("select Password from Teacher where [ID]=" + id + ";");
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
                            ADB.linkUpdate("update Teacher set [Password]='" + tbNewPWD.Text + "' where [ID]=" + id + ";");
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
            else
            {
                MessageBox.Show("您的数据有问题，请检查您的数据！");
            }
        }

        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path);
            Application.Exit();
        }
    }
}

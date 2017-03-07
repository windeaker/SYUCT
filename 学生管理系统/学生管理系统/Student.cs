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
using System.Collections;

namespace 学生管理系统
{
    public partial class Student : Form
    {
        String id = null;
        private String path = Application.StartupPath + "\\temp.txt";
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
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
            getAllClass();
            getTeacher();
            getThisInformation();
        }
        private void getAllClass()
        {
            ArrayList al = new ArrayList();
            DBControl SDB = new DBControl();
            SqlDataReader gAchievement = SDB.linkQuery("select CourseID from Teaching where StuID=" + id + ";");
            while (gAchievement.Read())
            {
                //listBox1.Items.Add(gAchievement.GetInt32(0));
                al.Add(gAchievement.GetInt32(0));
            }
            gAchievement.Close();
            listBox1.Items.Clear();
            for (int i = 0; i < al.Count; i++)
            {
                SqlDataReader getName = SDB.linkQuery("select Name from Course where ID=" + al[i].ToString() + ";");
                getName.Read();
                listBox1.Items.Add(getName.GetString(0)+"*"+al[i]);
                getName.Close();
            }
            SDB.Close();
        }
        private void getTeacher()
        {
            ArrayList al = new ArrayList();
            DBControl SDB = new DBControl();
            SqlDataReader getTeachID = SDB.linkQuery("select TeachID from Teaching where StuID=" + id + ";");
            while (getTeachID.Read())
            {
                //listBox1.Items.Add(gAchievement.GetInt32(0));
                al.Add(getTeachID.GetInt32(0));
            }
            getTeachID.Close();
            listBox2.Items.Clear();
            for (int i = 0; i < al.Count; i++)
            {
                SqlDataReader getName = SDB.linkQuery("select Name from Teacher where ID=" + al[i].ToString() + ";");
                getName.Read();
                //listBox2.Items.Add(getName.GetString(0) + "*" + al[i]);
                listBox2.Items.Add(getName.GetString(0));
                getName.Close();
            }
            SDB.Close();
        }
        private void getThisInformation()
        {
            ArrayList al = new ArrayList();
            DBControl SDB = new DBControl();
            SqlDataReader getID = SDB.linkQuery("select * from Student where ID=" + id + ";");
            getID.Read();
            for (int j = 0; j < 7; j++)
            {
                al.Add(getID.GetValue(j).ToString());
            }
            getID.Close();
            SDB.Close();
            listBox3.Items.Clear();
            listBox3.Items.Add("学号：" + al[0].ToString());
            listBox3.Items.Add("姓名：" + al[1].ToString());
            listBox3.Items.Add("性别：" + al[2].ToString());
            listBox3.Items.Add("学院：" + al[3].ToString());
            listBox3.Items.Add("班级：" + al[4].ToString());
            listBox3.Items.Add("专业：" + al[5].ToString());
            listBox3.Items.Add("密码：" + al[6].ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            String[] temp =listBox1.SelectedItem.ToString().Split('*');
            DBControl SDB = new DBControl();
            
            //SqlDataReader getCourseInfo = SDB.linkQuery("select * from Course where ID=" + al[1].ToString() + ";");
            //getCourseInfo.Read();
            //al.Add(getCourseInfo.GetValue(0).ToString());

            SqlDataReader getTeachingInfo = SDB.linkQuery("select * from Teaching where StuID=" + id + " and CourseID="+temp[1]+";");
            getTeachingInfo.Read();
            for (int j = 0; j < 7; j++)
            {
                al.Add(getTeachingInfo.GetValue(j).ToString());
            }
            getTeachingInfo.Close();
            SqlDataReader getTeacherName = SDB.linkQuery("select Name from Teacher where ID=" + al[1].ToString() + ";");
            getTeacherName.Read();
            al.Add(getTeacherName.GetValue(0).ToString());
            getTeacherName.Close();
            SDB.Close();
            MessageBox.Show("课程名：" + temp[0] + "\n"+"授课教师："+al[7].ToString()+"\n成绩："+al[3].ToString()+"\n授课教室"+al[4].ToString()+"\n授课时间："+al[5].ToString()+"\n备注："+al[6].ToString());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           // String[] temp = listBox2.SelectedItem.ToString().Split('*');
            DBControl SDB = new DBControl();
            SqlDataReader getTeacherInfo = SDB.linkQuery("select College from Teacher where Name='" + listBox2.SelectedItem.ToString() + "' ;");
            getTeacherInfo.Read();
            MessageBox.Show("教师姓名：" + listBox2.SelectedItem.ToString() +"\n所属学院："+ getTeacherInfo.GetValue(0).ToString());
            getTeacherInfo.Close();
            SDB.Close();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox3.SelectedIndex)
            {
                case 6:
                    SUpdatePWD s = new SUpdatePWD();
                    s.ShowDialog();
                    //this.Hide();
                    break;
                default:
                    MessageBox.Show("您没有足够的权限修改！");
                    break;
            }
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path);
            Application.Exit();
        }
    }
}

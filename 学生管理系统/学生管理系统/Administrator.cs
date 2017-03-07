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
    public partial class Administrator : Form
    {
        String id = null;
        private String path = Application.StartupPath + "\\temp.txt";

        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path);
            Application.Exit();
        }
        //学生表查询操作
        private void btSearchAll_Click(object sender, EventArgs e)
        {
            bsStudent.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader sr= ADB.linkQuery("select * from Student;");
            if (sr.HasRows)
            {
                bsStudent.DataSource = sr;
                dataGridView1.DataSource = bsStudent;
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "学院";
                dataGridView1.Columns[4].HeaderText = "班级";
                dataGridView1.Columns[5].HeaderText = "专业";
                dataGridView1.Columns[6].HeaderText = "登陆密码";
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("没有数据！");
            }
            sr.Close();
            ADB.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            bsStudent.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader sr = ADB.linkQuery("select * from Student where Name like '%" + tbS.Text + "%';");

            if (sr.HasRows)
            {
                bsStudent.DataSource = sr;
                dataGridView1.DataSource = bsStudent;
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "学院";
                dataGridView1.Columns[4].HeaderText = "班级";
                dataGridView1.Columns[5].HeaderText = "专业";
                dataGridView1.Columns[6].HeaderText = "登陆密码";
            }
            else
            {
                MessageBox.Show("没有数据！");
            }
            dataGridView1.Refresh();
            sr.Close();
            ADB.Close();
        }

        private void tbDeleteAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("请选择记录！");
                return;
            }
            if (MessageBox.Show(this, "是否删除此记录", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedRows[i - 1].Cells[0].Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);
                    //使用获得的ID删除数据库的数据
                    string SQL1 = "delete from Student where ID=" + ID.ToString() + ";";
                    string sql2 = "delete from Teaching where StuID=" + ID.ToString() + ";";
                    DBControl ADB = new DBControl();
                    ADB.linkUpdate(sql2);
                    ADB.linkUpdate(SQL1);
                    ADB.Close();
                }
            }
        }
//教师表查询相应操作
        private void tbTeacherShowAll_Click(object sender, EventArgs e)
        {
            bsTeacher.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader sr = ADB.linkQuery("select * from Teacher;"); 
            if (sr.HasRows)
            {
                bsTeacher.DataSource = sr;
                dataGridViewTeacher.DataSource = bsTeacher;
                dataGridViewTeacher.Columns[0].HeaderText = "工号";
                dataGridViewTeacher.Columns[1].HeaderText = "姓名";
                dataGridViewTeacher.Columns[2].HeaderText = "学院";

                dataGridViewTeacher.Columns[3].HeaderText = "登陆密码";
            }
            else
            {
                MessageBox.Show("没有数据！");
            }
            dataGridViewTeacher.Refresh();
            sr.Close();
            ADB.Close();
        }

        private void btTSearch_Click(object sender, EventArgs e)
        {
            bsTeacher.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader sr = ADB.linkQuery("select * from Teacher where Name like '%" + tbT.Text + "%';");
            if (sr.HasRows)
            {
                bsTeacher.DataSource = sr;
                dataGridViewTeacher.DataSource = bsTeacher;
                dataGridViewTeacher.Columns[0].HeaderText = "工号";
                dataGridViewTeacher.Columns[1].HeaderText = "姓名";
                dataGridViewTeacher.Columns[2].HeaderText = "学院";

                dataGridViewTeacher.Columns[3].HeaderText = "登陆密码";
            }
            else
            {
                MessageBox.Show("没有数据！");
            }

            dataGridViewTeacher.Refresh();
            sr.Close();
            ADB.Close();
        }

        private void btTDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeacher.RowCount <= 0)
            {
                MessageBox.Show("请选择记录！");
                return;
            }
            if (MessageBox.Show(this, "是否删除此记录", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = this.dataGridViewTeacher.SelectedRows.Count; i > 0; i--)
                {
                    int ID = Convert.ToInt32(dataGridViewTeacher.SelectedRows[i - 1].Cells[0].Value);
                    dataGridViewTeacher.Rows.RemoveAt(dataGridViewTeacher.SelectedRows[i - 1].Index);
                    //使用获得的ID删除数据库的数据
                    string SQL1 = "delete from Teach where ID=" + ID.ToString() + ";";
                    string sql2 = "delete from Teaching where TeachID=" + ID.ToString() + ";";
                    DBControl ADB = new DBControl();
                    ADB.linkUpdate(sql2);
                    ADB.linkUpdate(SQL1);
                    ADB.Close();
                }
            }
        }

        //更新学生表
        private void btAddStudent_Click(object sender, EventArgs e)
        {
            if (tbSID.Text != null && tbSMajor.Text != null && tbSClass.Text != null && tbSCollege.Text != null && tbSName.Text != null && cbSSex.SelectedItem != null)
            {
                DBControl ADB = new DBControl();
                ADB.linkUpdate("insert into Student(ID,Name,Sex,College,Class,Major,Password) values(" + tbSID.Text + ",'" + tbSName.Text + "','" + cbSSex.SelectedItem.ToString() + "','" + tbSCollege.Text + "','" + tbSClass.Text + "','" + tbSMajor.Text + "'," + tbSID.Text + ");");
                MessageBox.Show("更新成功！");
                ADB.Close();
                tbSID.Clear();
                tbSMajor.Clear();
                tbSClass.Clear();
                tbSCollege.Clear(); ;
                tbSName.Clear();
            }
            else
            {
                MessageBox.Show("您的数据输入不完整，请检查您的数据！");
            }
            
        }
        //添加教师表
        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            if (tbTCollege.Text != null && tbTID.Text != null && tbTName.Text != null)
            {
                DBControl ADB = new DBControl();
                ADB.linkUpdate("insert into Teacher(ID,Name,College,Password) values(" + tbTID.Text + ",'" + tbTName.Text + "','" + tbTCollege.Text + "'," + tbTID.Text + ");");
                MessageBox.Show("更新成功！");
                ADB.Close();
                tbTCollege.Clear();
                tbTID.Clear();
                tbTName.Clear();
            }
            else
            {
                MessageBox.Show("您的数据输入不完整，请检查您的数据！");
            }
        }
        //添加数据至课程表
        private void btAddCourse_Click(object sender, EventArgs e)
        {
            if (tbCID.Text != null && tbCName.Text != null && tbCCredit.Text != null)
            {
                DBControl ADB = new DBControl();
                ADB.linkUpdate("insert into Course(ID,Name,Credit,Remarks) values(" + tbCID.Text + ",'" + tbCName.Text + "'," + tbCCredit.Text + ",'" + tbCRemarks.Text + "');");
                MessageBox.Show("更新成功！");
                ADB.Close();
                tbCID.Clear();
                tbCName.Clear();
                tbCCredit.Clear();
                tbCRemarks.Clear();
            }
            else
            {
                MessageBox.Show("您的数据输入不完整，请检查您的数据！");
            }
        }

        //判断用户，以及初始化页面中的下拉列表框
        private void Administrator_Load(object sender, EventArgs e)
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
            initialCB();
        }
        private void initialCB()
        {
            cbSID.Items.Clear();
            cbTID.Items.Clear();
            cbCID.Items.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader ssdr = ADB.linkQuery("select * from Student;");
            while (ssdr.Read())
            {
                cbSID.Items.Add(ssdr.GetValue(1).ToString());
            }
            ssdr.Close();
            SqlDataReader tsdr = ADB.linkQuery("select * from Teacher;");
            while (tsdr.Read())
            {
                cbTID.Items.Add(tsdr.GetString(1));
            }
            tsdr.Close();
            SqlDataReader csdr = ADB.linkQuery("select * from Course;");
            while (csdr.Read())
            {
                cbCID.Items.Add(csdr.GetString(1));
            }
            csdr.Close();
            ADB.Close();
        }

        //添加教学计划

        private void btAddTeaching_Click(object sender, EventArgs e)
        {
            if (tbTeachTime.Text != null && tbClassroom.Text != null && cbSID.SelectedItem != null && cbTID.SelectedItem != null && cbCID.SelectedItem != null)
            {
                int sid = 0;
                int tid = 0;
                int cid = 0;
                DBControl ADB = new DBControl();
                SqlDataReader gSID = ADB.linkQuery("select ID from Student where Name='" + cbSID.SelectedItem.ToString() + "';");
                if (gSID.Read())
                {
                    sid = gSID.GetInt32(0);
                }
                gSID.Close();
                SqlDataReader gTID = ADB.linkQuery("select ID from Teacher where Name='" + cbTID.SelectedItem.ToString() + "';");
                if (gTID.Read())
                {
                    tid = gTID.GetInt32(0);
                }
                gTID.Close();
                SqlDataReader gCID = ADB.linkQuery("select ID from Course where Name='" + cbCID.SelectedItem.ToString() + "';");
                if (gCID.Read())
                {
                    cid = gCID.GetInt32(0);
                }
                gCID.Close();
                //MessageBox.Show(sid.ToString()+"**"+tid.ToString()+"$$"+cid.ToString());
                ADB.linkUpdate("insert into Teaching(StuID,TeachID,CourseID,Classroom,TeachTime,Remarks) values(" + sid.ToString() + "," + tid.ToString() + "," + cid.ToString() + ",'" + tbClassroom.Text + "','" + tbTeachTime.Text + "','" + tbRemarks.Text + "')");
                MessageBox.Show("更新成功");
                ADB.Close();
                tbTeachTime.Clear();
                tbClassroom.Clear();
                tbRemarks.Clear();
            }
            else
            {
                MessageBox.Show("您的数据输入不完整，请检查您的数据！");
            }

        }

        //更改密码

        private void btUpdatePWD_Click(object sender, EventArgs e)
        {
            if (tbThisPWD.Text != null && tbForePWD.Text != null && tbCheckPWD.Text != null)
            {
                DBControl ADB = new DBControl();
                SqlDataReader gForePWD = ADB.linkQuery("select Password from Admin  where [ID]=" + id + ";");
                gForePWD.Read();
                String forePWD = gForePWD.GetString(0);
                gForePWD.Close();
                //MessageBox.Show(gForePWD.GetString(0));
                if (tbThisPWD.Text.Equals(tbCheckPWD.Text))
                {
                    if (tbThisPWD.Text.Equals(forePWD))
                    {
                        MessageBox.Show("不能与原密码相同！");
                    }
                    else
                    {
                        ADB.linkUpdate("update Admin set [Password]='" + tbThisPWD.Text + "' where [ID]=" + id + ";");
                        MessageBox.Show("更改成功！");
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
                MessageBox.Show("您的数据输入不完整，请检查您的数据！");
            }
            tbForePWD.Clear();
            tbThisPWD.Clear();
            tbCheckPWD.Clear();

        }

        //查询教学计划页面的操作
        private void btTShowAll_Click(object sender, EventArgs e)
        {
            bsTeaching.Clear();
            DBControl ADB = new DBControl();
            SqlDataReader sr = ADB.linkQuery("select Student.Name,Course.Name,Teacher.Name,Teaching.Achievement,Course.Credit,Teaching.Classroom,Teaching.TeachTime,Teaching.Remarks from Student,Teaching,Course,Teacher where Teaching.StuID=Student.ID and Teaching.CourseID=Course.ID and Teaching.TeachID=Teacher.ID;");
            if (sr.HasRows)
            {
                bsTeaching.DataSource = sr;
                dataGridView2.DataSource = bsTeaching;
                dataGridView2.Columns[0].HeaderText = "学生姓名";
                dataGridView2.Columns[1].HeaderText = "课程名";
                dataGridView2.Columns[2].HeaderText = "教师姓名";
                dataGridView2.Columns[3].HeaderText = "成绩";
                dataGridView2.Columns[4].HeaderText = "学分";
                dataGridView2.Columns[5].HeaderText = "上课地点";
                dataGridView2.Columns[6].HeaderText = "上课时间";
                dataGridView2.Columns[7].HeaderText = "备注";
            }
            else
            {
                MessageBox.Show("没有数据！");
            }
            dataGridView2.Refresh();
            sr.Close();
            ADB.Close();
        }

        private void btTTDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount <= 0)
            {
                MessageBox.Show("请选择记录！");
                return;
            }
            if (MessageBox.Show(this, "是否删除此记录", "请确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = this.dataGridView2.SelectedRows.Count; i > 0; i--)
                {
                    int ID = Convert.ToInt32(dataGridView2.SelectedRows[i - 1].Cells[0].Value);
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[i - 1].Index);
                    //使用获得的ID删除数据库的数据
                   
                    string sql2 = "delete from Teaching where StuID=" + ID.ToString() + ";";
                    DBControl ADB = new DBControl();
                    ADB.linkUpdate(sql2);
                    ADB.Close();
                }
            }
        }
        //设置文本框只允许输入数字
        private void tbSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 学生管理系统
{
    class DBControl
    {
        private SqlConnection con;
        public DBControl()
        {
            con = new SqlConnection();
            con.ConnectionString = @"server=Windeaker-PC\SQLEXPRESS;database=StudentManageSystem;integrated security=true";
            con.Open();
        }
        public void Close()
        {
            con.Close();
        }
        public void linkUpdate(String sql)
        {
            try
            {
                SqlCommand scmd = new SqlCommand(sql, con);
                scmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("您的值有误!");
            }
        }
        public SqlDataReader linkQuery(String sql)
        {
            SqlCommand scmd = new SqlCommand(sql, con);
            return scmd.ExecuteReader();
        }
        public SqlDataAdapter Query(String sql)
        {
            return new SqlDataAdapter(sql, con);
        }
    }
}

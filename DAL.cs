using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.DataFormats;

namespace CRUD
{
    internal class DAL
    {
        
        public static SqlConnection GetConnection()
        {
            string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = CRUD;
                             Integrated Security = true";


            /*   Data source=server name;
               intial catalog=Database Name
               integrated security = true*/
            SqlConnection conn = new SqlConnection(sql);
            conn.Open();
            return conn;
        }
        public static int t = 0;

       

        public static void AddStudent(string name,string reg,string phone,string address,string gender)
        {
            string sql = "INSERT INTO Student_Table VALUES (@StudentName,@StudentRegister,@StudentPhone,@StudentAddress,@StudentGender)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@StudentName",name);
            cmd.Parameters.AddWithValue("@StudentRegister",reg);
            cmd.Parameters.AddWithValue("@StudentPhone", phone);
            cmd.Parameters.AddWithValue("@StudentAddress",address);
            cmd.Parameters.AddWithValue("@StudentGender", gender);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added successfully","successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                t = 1;

            }
            catch(SqlException ex)
            {
                if(ex.Number==2627)
                {
                    MessageBox.Show("Duplicate Registration No","info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error Ocuurred : "+ex.ToString(),"info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        public static void UpdateStudent(string name, string reg, string phone, string address, string gender)
        {
            string sql = "UPDATE Student_Table SET Student_Name=@StudentName,Student_Phone=@StudentPhone,Student_Address=@StudentAddress,Student_Gender=@StudentGender WHERE Student_Register=@StudentRegister";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@StudentName", name);
            cmd.Parameters.AddWithValue("@StudentRegister", reg);
            cmd.Parameters.AddWithValue("@StudentPhone", phone);
            cmd.Parameters.AddWithValue("@StudentAddress", address);
            cmd.Parameters.AddWithValue("@StudentGender", gender);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data upadted successfully", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t = 1;

            }
            catch (SqlException ex)
            { 
                MessageBox.Show("Error Ocuurred : " + ex.ToString(), "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            conn.Close();
        }
        
        public static void DeleteStudent(string reg)
        {
            string sql = "DELETE FROM Student_Table WHERE Student_Register=@StudentRegister"; 
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
           
            cmd.Parameters.AddWithValue("@StudentRegister", reg);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted successfully", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t = 1;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Ocuurred : " + ex.ToString(), "info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }


        public static SqlCommand Dislpayallstudents()
        {
            string sql = "SELECT * FROM Student_table";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd;
        }

        public static SqlCommand Searchstudents(string Reg)
        {
            string sql = "SELECT * FROM Student_table WHERE Student_Register LIKE '%" +Reg+ "%'";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd;
        }
    }
}

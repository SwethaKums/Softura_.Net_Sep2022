using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Konsole
{
    internal class TaskDataBase1
    {
        public void Data()
        {
            SqlConnection com = new SqlConnection("Data source=LAPTOP-CCNCPJ77; database=Test; user id=sa; password=p@ssword");
            com.Open();
            SqlCommand cmd = new SqlCommand("select festname from festival",com);
           cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString());
            }
            com.Close();
        }

        public void insData1(int DeptId,string DeptName)
        {
            SqlConnection com = new SqlConnection("Data source=LAPTOP-CCNCPJ77; database=Test; user id=sa; password=p@ssword");
            SqlCommand cmd = new SqlCommand("sp_deppt", com);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Deptid", SqlDbType.Int).Value=DeptId;
            cmd.Parameters.AddWithValue("@DName", SqlDbType.Int).Value=DeptName;
            com.Open();
            cmd.ExecuteNonQuery();
            com.Close();
            Console.WriteLine("inserted");
        }
        public static void Main()
        {
            TaskDataBase1 database = new TaskDataBase1();
            database.Data();
            database.insData1(005, "Technical");

        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
    class Student
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static ArrayList viewList()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Students", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
    class ClassInformation
    {
        //Number fields
        private string subjName;
        private string charges;
        private string classschedule;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string SubjName { get => subjName; set => subjName = value; }
        public string Charges { get => charges; set => charges = value; }
        public string Classschedule { get => classschedule; set => classschedule = value; }

        public ClassInformation(string sn, string c, string cs)
        {
            subjName = sn;
            charges = c;
            classschedule = cs;
        }

        public ClassInformation(string sn)
        {
            subjName = sn;
        }

        public string addClassInfo()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ClassInfo(Subject Name, Charges, Class Schedule) values(@name, @char, @sche)", con);
            cmd.Parameters.AddWithValue("@name", subjName);
            cmd.Parameters.AddWithValue("@char", charges);
            cmd.Parameters.AddWithValue("@sche", classschedule);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Class information added successful.";
            else
                status = "Fail to add class information.";
            con.Close();
            return status;
        }

        public string updateClassInfo(string ch, string cs)
        {
            string status;
            con.Open();

            charges = ch;
            classschedule = cs;

            SqlCommand cmd = new SqlCommand("update ClassInfo set Charges ='" + charges + "',Class Schedule='" + classschedule + "' where Subject Name ='" + subjName + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Class information updated successful.";
            else
                status = "Fail to update class information.";
            con.Close();
            return status;
        }

        public string deleteClassInfo(string ch, string cs)
        {
            string status;
            con.Open();

            charges = ch;
            classschedule = cs;

            SqlCommand cmd = new SqlCommand("delete ClassInfo set Charges ='" + charges + "',Class Schedule='" + classschedule + "' where Subject Name ='" + subjName + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Class information deleted successful.";
            else
                status = "Fail to delete class information.";
            con.Close();
            return status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
    internal class TutorProfile
    {
        private string name;
        private string password;
        private string phoneNum;
        private string email;
        private string subject;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }

        public TutorProfile(string n, string p, string pN, string e, string s)
        {
            Name = n;
            Password = p;
            PhoneNum = pN;
            Email = e;
            Subject = s;
        }

        public TutorProfile(string n)
        {
            Name = n;
        }

        public string updateTutorProfile(string pass, string pN, string e, string s)
        {
            string status;
            con.Open();

            password = pass;
            phoneNum = pN;
            email = e;
            subject = s;

            SqlCommand cmd = new SqlCommand("update Profile set password ='" + password + "',phonenumber='" + phoneNum + "',email='" + email + "',subject='" + subject + "' where username ='" + name + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Tutor profile updated successful.";
            else
                status = "Fail to update tutor profile.";
            con.Close();
            return status;
        }
    }
}

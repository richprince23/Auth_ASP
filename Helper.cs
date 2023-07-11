using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Auth
{
    public static class Helper
    {
        static string conString = @"Data Source=DESKTOP-DEVKGOD\SQLEXPRESS;Initial Catalog=edcourse;Integrated Security=True;Pooling=False";
        static SqlConnection con = new SqlConnection(conString);


        private static bool isEmailExists(string email)
        {
            bool res = false;
            SqlCommand cmd = new SqlCommand("select email from users where email = @email", con);
            cmd.Parameters.AddWithValue("@email", email.Trim());

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                res = true;
            }

            con.Close();

            return res;
        }
        public static string login(string email, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from users where email = @email and pass = @pass;", con);
                cmd.Parameters.AddWithValue("@email", email.Trim());
                cmd.Parameters.AddWithValue("@pass", password);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    con.Close();
                    return "Login successful!";
                }

                con.Close();
                return "Invalid email or password!";
            }
            catch (Exception ex)
            {
                return "An error occurred. Please try again!";
            }
        }

        public static string register(string fullname, string email, string phone, string password) {
            try
            {
                if (isEmailExists(email) == true)
                {
                    return "Email already exists!";
                }

                SqlCommand cmd = new SqlCommand("insert into users(fullname, email, phone, pass) values (@name, @email, @phone, @pass);", con);
                cmd.Parameters.AddWithValue("@name", fullname.Trim());
                cmd.Parameters.AddWithValue("@email", email.Trim());
                cmd.Parameters.AddWithValue("@phone", phone.Trim());
                cmd.Parameters.AddWithValue("@pass", password);

                con.Open();
                int res = cmd.ExecuteNonQuery();

                if (res != 0)
                {
                    con.Close();
                    return "Account created successfully!";
                }

                con.Close();
                return "Account creation failed!";
            }
            catch (Exception ex)
            {
                //return "An error occurred. Please try again!";
                return ex.Message;
            }
        }

    }
}
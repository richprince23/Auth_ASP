using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Security.Cryptography;
using System.Text;

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
        public static Dictionary<string, string> login(string email, string password)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("success", "");
            result.Add("error", "");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from users where email = @email and pass = @pass;", con);
                cmd.Parameters.AddWithValue("@email", email.Trim());
                cmd.Parameters.AddWithValue("@pass", makeHash(password.Trim()));

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    con.Close();
                    
                    result["success"] =  "Login successful!";
                    return result;
                }

                con.Close();

                result["error"] = "Invalid Email or Password!";
                return result;
            }
            catch (Exception ex)
            {
                con.Close();
                result["error"] = "An error occurred. Please try again!";
                return result;
            }
        }

        public static Dictionary<string, string> register(string fullname, string email, string phone, string password) {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("success", "");
            result.Add("error", "");
            try
            {

                if (isEmailExists(email) == true)
                {
                    result["error"]= "Email already exists!";
                    //return  "Email already exists!" ;
                    return result;
                }

                SqlCommand cmd = new SqlCommand("insert into users(fullname, email, phone, pass) values (@name, @email, @phone, @pass);", con);
                cmd.Parameters.AddWithValue("@name", fullname.Trim());
                cmd.Parameters.AddWithValue("@email", email.Trim());
                cmd.Parameters.AddWithValue("@phone", phone.Trim());
                cmd.Parameters.AddWithValue("@pass", makeHash(password.Trim()));

                con.Open();
                int res = cmd.ExecuteNonQuery();

                if (res != 0)
                {
                    con.Close();
                    result["success"] = "Account created successfully!";
                    return result;
                }

                con.Close();
                result["error"] = "Account creation failed!";
                return result;
            }
            catch (Exception ex)
            {
                //return "An error occurred. Please try again!";
                con.Close();
                result["error"] = "Account creation failed!";
                return result;
            }
        }

        private static string makeSalt(int size){
            MD5CryptoServiceProvider rng = new MD5CryptoServiceProvider();
            byte[] buffer = new byte[size];
            rng.ComputeHash(buffer);
            return Convert.ToBase64String(buffer);
        }

        private static string makeHash(string passwod){
            string salt = makeSalt(10);
            byte[] bytes = Encoding.UTF8.GetBytes(passwod + salt);
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            byte[] hash = sha.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model.auth
{
    class Profiles : Database
    {
        public string password { get; set; }
        public string id { get; set; }
        public string oldPassword { get; set; }

        //Method to check and verify the data in the db
        public bool password_verification()
        {
            bool check = false;
            //open database connection

            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT password FROM users WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    check = true;
                    oldPassword = rd.GetString("password");
                }

                conn.Close();
            }

            return check;
        }

        //Update
        public void updatePassword()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE users SET password = @password WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

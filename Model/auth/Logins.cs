using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model.auth
{
    class Logins : Database
    {
        public string username { get; set; }
        public string Password { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string id { get; set; }

        //Method to check and verify the data in the db
        public bool user_verification()
        {
            bool check = false;
            //open database connection

            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        name = rd.GetString("name");
                        username = rd.GetString("username");
                        phone = rd.GetString("telephone");
                        id = rd.GetString("id");
                    }
                }
                finally
                {
                    conn.Close();
                }
            }

            return check;
        }



        //Method to check and verify the data in the db
        public bool voter_verification()
        {
            bool check = false;
            //open database connection

            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "SELECT * FROM voters WHERE index_number=@index AND token=@token";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@index", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@token", MySqlDbType.VarChar).Value = Password;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        name = rd.GetString("name");
                       status = rd.GetString("status");
                        id = rd.GetString("id");
                    }
                }
                finally
                {
                    conn.Close();
                }
            }

            return check;
        }
        
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Voters : Database
    {
        public string gender { get; set; }
        public string classID { get; set; }
        public string name { get; set; }
        public string index_number { get; set; }
        public string check_index_number { get; set; }
        public string status { get; set; }
        public string token { get; set; }
        public string id { get; set; }

        private DateTime now = DateTime.Now;

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();


        public bool indexNumberExist()
        {
            bool check = false;
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM voters WHERE index_number = @index_number";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@index_number", MySqlDbType.VarChar).Value = index_number;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        check_index_number = rd.GetString("index_number");
                    }

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

            return check;
        }

        public void getClass()
        {
            dt.Clear();
            string sql = "SELECT * FROM class ORDER BY id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void show()
        {
            dat.Clear();
            string sql = "SELECT * FROM voters ORDER BY id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }

        public void store()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO voters(class_id, name, gender, index_number, token) VALUES(@class, @name, @gender, @index_number, @token)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = classID;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@index_number", MySqlDbType.VarChar).Value = index_number;
                    cmd.Parameters.Add("@token", MySqlDbType.VarChar).Value = token;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void update()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE voters SET class_id = @class, name = @name, gender =@gender, token=@token, updated_at = '" + now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = classID;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@token", MySqlDbType.VarChar).Value = token;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void destroy()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM voters WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

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

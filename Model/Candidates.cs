using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Candidates : Database
    {
        public byte[] picture { get; set; }
        public string party { get; set; }
        public string name { get; set; }
        public string election { get; set; }
        public string id { get; set; }

        private DateTime now = DateTime.Now;

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();



        public void getElection()
        {
            dt.Clear();
            string sql = "SELECT * FROM election ORDER BY id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void show()
        {
            dat.Clear();
            string sql = "SELECT candidate.id, candidate.name, candidate.picture, candidate.party, election.type AS Position, candidate.created_at, candidate.updated_at FROM candidate INNER JOIN election ON election.id = candidate.election_id ORDER BY id DESC";
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
                    cmd.CommandText = "INSERT INTO candidate(name, picture, party, election_id) VALUES(@name, @picture, @party, @election)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@picture", MySqlDbType.VarBinary).Value = picture;
                    cmd.Parameters.Add("@party", MySqlDbType.VarChar).Value = party;
                    cmd.Parameters.Add("@election", MySqlDbType.VarChar).Value = election;
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
                    cmd.CommandText = "UPDATE candidate SET name = @name, picture=@picture, party=@party, election_id = @election, updated_at = '" + now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@picture", MySqlDbType.VarBinary).Value = picture;
                    cmd.Parameters.Add("@party", MySqlDbType.VarChar).Value = party;
                    cmd.Parameters.Add("@election", MySqlDbType.VarChar).Value = election;
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
                    cmd.CommandText = "DELETE FROM candidate WHERE id=@id";
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

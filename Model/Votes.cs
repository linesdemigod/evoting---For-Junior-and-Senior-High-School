using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Votes : Database
    {
        public string voter { get; set; }
        public string candidate { get; set; }
        public string position { get; set; }
        public string status { get; set; }
        public string id { get; set; }

        private DateTime now = DateTime.Now;

        public void store()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO vote(voter_id, candidate_id, election_id) VALUES(@voter, @candidate, @position)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@voter", MySqlDbType.VarChar).Value = voter;
                    cmd.Parameters.Add("@candidate", MySqlDbType.VarChar).Value = candidate;
                    cmd.Parameters.Add("@position", MySqlDbType.VarChar).Value = position;
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

        public void updateVoterStatus()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE voters SET status = @status, updated_at = '" + now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
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
    }
}

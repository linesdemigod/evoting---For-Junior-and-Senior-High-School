using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Reports : Database
    {
        public string id { get; set; }
        public string voters { get; set; }

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //SELECT candidate.name, election.type AS Position, Count(vote.candidate_id) AS Votes, election.id AS PositionID FROM vote INNER JOIN candidate ON candidate.id = vote.candidate_id INNER JOIN election ON election.id = vote.election_id WHERE vote.election_id = @id GROUP BY vote.candidate_id

        public void getReport()
        {
            dt.Clear();
            string sql = "SELECT candidate.name, Count(vote.candidate_id) AS Votes FROM vote INNER JOIN candidate ON candidate.id = vote.candidate_id WHERE vote.election_id =@id GROUP BY vote.candidate_id";
            MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter
            {
                SelectCommand = selectCMD
            };
            selectCMD.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            conn.Close();
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void countVoters()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(id) AS voters FROM voters";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        voters = rd.GetString("voters");
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

            
        }

        public void countVoteCast()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(election_id) AS Votes FROM vote WHERE election_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        voters = rd.GetString("Votes");
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


        }
    }
}

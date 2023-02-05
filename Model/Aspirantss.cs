using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Aspirantss : Database
    {
        public List<Tuple<string, string, byte[], string, string>> records = new List<Tuple<string, string, byte[], string, string>>();
        public List<Tuple<string, string>> data = new List<Tuple<string, string>>();
        public string id { get; set; }


        public void show()
        {
            
            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "SELECT candidate.id, candidate.name, candidate.picture, candidate.party, election.type AS Position, candidate.created_at, candidate.updated_at FROM candidate INNER JOIN election ON election.id = candidate.election_id WHERE election.id = @id ORDER BY Position DESC";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        
                        string id = rd.GetString("id");
                        string name = rd.GetString("name");
                        byte[] imageData = (byte[])rd["picture"];
                        string party = rd.GetString("party");
                        string position = rd.GetString("position");

                        records.Add(new Tuple<string, string, byte[], string, string>(id, name, imageData, party, position));
                    }
                }
                finally
                {
                    conn.Close();
                }
            }

            
        }




        public void getPosition()
        {

            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "SELECT id, type FROM election";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {

                        string id = rd.GetString("id");
                        string name = rd.GetString("type");
                        

                        data.Add(new Tuple<string, string>(id, name));
                    }
                }
                finally
                {
                    conn.Close();
                }
            }


        }

        //string sql = "SELECT user.name as staff, bank.description AS description, bank.deposit as deposit,  bank.withdrawal as withdrawal, bank.date AS date, bank.created_at AS time FROM bank INNER JOIN user ON user.id = bank.user_id WHERE Year(bank.created_at) = @year ORDER BY bank.id DESC";
        //MySqlCommand selectCMD = new MySqlCommand(sql, conn);
        //MySqlDataAdapter dta = new MySqlDataAdapter
        //{
        //    SelectCommand = selectCMD
        //};
        //selectCMD.Parameters.Add("@year", MySqlDbType.VarChar).Value = getYear;
        //    conn.Close();
        //    dta.Fill(ds);
        //    dt = ds.Tables[0];
    }
}

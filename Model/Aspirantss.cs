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
        public List<Tuple<string, string, byte[], string, string, string>> records = new List<Tuple<string, string, byte[], string, string, string>>();
        public List<Tuple<string, string>> data = new List<Tuple<string, string>>();
        public string id { get; set; }


        public void show()
        {
            
            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "SELECT candidate.id, candidate.name, candidate.picture, candidate.party, election.type AS Position, election.id AS PositionID FROM candidate INNER JOIN election ON election.id = candidate.election_id WHERE election.id = @id ORDER BY Position DESC";
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
                        string positionID = rd.GetString("PositionID");

                        records.Add(new Tuple<string, string, byte[], string, string,string>(id, name, imageData, party, position, positionID));
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

       
    }
}

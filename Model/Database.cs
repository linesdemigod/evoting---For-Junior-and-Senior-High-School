using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoting.Model
{
    class Database
    {
        public MySqlConnection conn;//connection to the database
        public MySqlCommand cmd;//help create sql statement
        public MySqlDataReader rd;//return data from the databaase

        public Database()
        {
            string source = "localhost";
            string port = "3308";
            string user = "root";
            string password = "rootcluster";
            string ssl = "none";
            string database = "evoting";
            string connection = $"datasource={source}; port={port}; user id={user}; password={password}; database={database}; SSL Mode={ssl}";
            conn = new MySqlConnection(connection);
        }
    }
}

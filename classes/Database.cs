using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Database
    {
        private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());
        private MySqlConnection connection;

        public Database()
        {
            string connectionString = "server=localhost;database=gym;user=root;password=;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public static Database Instance => instance.Value;

        public MySqlConnection Connection
        {
            get
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
        }
    }
}

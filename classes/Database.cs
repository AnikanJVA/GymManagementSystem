using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Database
    {
        private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());
        private static MySqlConnection connection;

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

        public static DataTable GetEquipmentsTable()
        {
            DataTable table = new DataTable();

            string query = @"SELECT e.equipmentID,
                            e.equipmentName,
                            e.brand,
                            e.model,
                            c.categoryName AS category,
                            e.cost,
                            e.quantity,
                            e.EquipmentCondition
                        FROM equipments e
                        JOIN equipmentcategories c 
                        ON e.categoryID = c.categoryID;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable GetMembersTable()
        {
            DataTable table = new DataTable();

            string query = @"SELECT 
                                memberID,
                                lastName,
                                firstName,
                                middleName,
                                DoB,
                                Sex,
                                contactNumber,
                                email,
                                DATE(membershipDate),
                                membershipType,
                                COALESCE(DATE(renewalDate), DATE('0000-00-00')) AS renewalDate,
                                membershipStatus
                            FROM 
                                members;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
                return table;
            }
        }
    }
}

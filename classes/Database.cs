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
                                m.memberID,
                                m.lastName,
                                m.firstName,
                                m.middleName,
                                m.DoB,
                                m.Sex,
                                m.contactNumber,
                                m.email,
                                DATE(m.membershipDate) as membershipDate,
                                DATE(m.renewalDate) as renewalDate,
                                m.membershipStatus,
                                mt.planName
                            FROM 
                                members m
                            INNER JOIN
                                membershiptypes mt
                            ON
                                m.planid = mt.planID;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
                return table;
            }
        }

        
        public static DataTable GetStaffsTable()
        {
            DataTable table = new DataTable();

            string query = @"SELECT
                                s.staffID,
                                s.firstName,
                                s.middleName,
                                s.lastName,
                                s.DoB,
                                s.Sex,
                                s.contactNumber,
                                s.email,
                                s.schedule,
                                p.positionName,
                                s.UserID,
                                u.username,
                                u.accType,
                                u.status
                            FROM
                                staffs s
                            INNER JOIN
                                users u 
                            ON 
                                s.userID = u.userID
                            INNER JOIN
                                positions p
                            ON
                                s.positionID = p.positionID";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
                return table;
            }
        }

        public static long GetCategoryName(string categoryName)
        {
            string selectQuery = "SELECT categoryID FROM equipmentcategories WHERE categoryName = @categoryName";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
            {
                cmd.Parameters.AddWithValue("@categoryName", categoryName);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt64(result);
                }
            }
            return 0;
        }

        public static long GetPositionID(string positionName)
        {
            string selectQuery = "SELECT positionID FROM positions WHERE positionName = @positionName";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
            {
                cmd.Parameters.AddWithValue("@positionName", positionName);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt64(result);
                }
            }
            return 0;
        }
    }
}

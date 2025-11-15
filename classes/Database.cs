using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Numerics;
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

            string query = @"SELECT e.EquipmentID,
                                e.EquipmentName,
                                e.Brand,
                                e.Model,
                                c.categoryName AS Category,
                                e.Cost,
                                e.Quantity
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
                                m.MemberID,
                                m.LastName,
                                m.FirstName,
                                m.MiddleName,
                                m.DoB,
                                m.Sex,
                                m.ContactNumber,
                                m.Email,
                                DATE(m.membershipDate) as MembershipDate,
                                DATE(m.expirationDate) as ExpiraationDate,
                                m.MembershipStatus,
                                mt.PlanName as Plan
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
                                s.StaffID,
                                s.FirstName,
                                s.MiddleName,
                                s.LastName,
                                s.DoB,
                                s.Sex,
                                s.ContactNumber,
                                s.Email,
                                s.Schedule,
                                p.PositionName,
                                s.Status
                            FROM
                                staffs s
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

        public static DataTable GetUsersTable()
        {
            DataTable table = new DataTable();

            string query = @"SELECT * FROM users";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
                return table;
            }
        }

        public static long GetEquipmentCategoryID(string categoryName)
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

        public static string GetEquipmentCategoryName(long categoryID)
        {
            string selectQuery = "SELECT categoryName FROM equipmentCategories WHERE categoryID = @categoryID";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
            {
                cmd.Parameters.AddWithValue("@categoryID", categoryID);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }
            return null;
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

        public static Equipment RetriveEquipment(long equipmentID)
        {
            Equipment equipment = new Equipment();

            string query = "SELECT * FROM Equipments WHERE equipmentID = @equipmentID";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        equipment.EquipmentID = Convert.ToInt64(reader["EquipmentID"]);
                        equipment.EquipmentName = reader["EquipmentName"].ToString();
                        equipment.Brand = reader["Brand"].ToString();
                        equipment.Model = reader["Model"].ToString();
                        equipment.CategoryID = Convert.ToInt64(reader["CategoryID"]);
                        equipment.Cost = Convert.ToInt64(reader["Cost"]);
                        equipment.Quantity = Convert.ToInt32(reader["Quantity"]);
                        reader.Close();
                        return equipment;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Trace.WriteLine("+++++++ Error retriveing Equipment: " + ex.Message);
                    return null;
                }
            }
            return null;
        }
    }
}

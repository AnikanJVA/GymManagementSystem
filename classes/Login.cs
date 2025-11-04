using ClassLibrary;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Login
    {
        private User currentUser;

        public Login()
        {
            currentUser = new User();
        }

        public User CurrentUser
        {
            get  { return currentUser; }
            set { currentUser = value; }
        }

        public bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA2(@password, 256) AND status = @status";
            using (MySqlCommand cmd = new MySqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@status", "ACTIVE");
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    currentUser = RetrieveUser(username);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public User RetrieveUser(string username)
        {
            User user = new User();
            string query = "SELECT * FROM users WHERE username = @username";

            using (MySqlCommand cmd = new MySqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        user.Id = Convert.ToInt64(reader["UserID"].ToString());
                        user.Username = username;
                        user.AccType = reader["AccType"].ToString();
                        user.Status = reader["Status"].ToString();

                        reader.Close();
                        return user;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving user: " + ex.Message);
                    return null;
                }
            }
            return null;
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AdminActions
    {
        private static MySqlConnection connection = Database.Instance.Connection;
        public bool addEquipment(int equipmentID,
                                        string eqiupmentName,
                                        string brand,
                                        string model,
                                        int categoryID,
                                        double cost,
                                        int quantity,
                                        string condition)
        {
            string checkQuery = @"SELECT COUNT(*) AS DuplicateCount
                                 FROM eqiupments
                                 WHERE EquipmentName = @equipmentName";
            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
            {
                checkCmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                checkCmd.Parameters.AddWithValue("@equipmentName", eqiupmentName);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    return false;
                }
            }
            string insertQuery = @"INSERT INTO equipments (equipmentID, equipmentName, brand, model, categoryID, cost, quantity, condition)
                                   VALUES (@equipmentID, @equipmentName, @brand, @model, @categoryID, @cost, @quantity, @condition);";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                cmd.Parameters.AddWithValue("@equipmentName", eqiupmentName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@condition", condition);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool updateEquipment(int equipmentID,
                                    string equipmentName,
                                    string brand,
                                    string model,
                                    int categoryID,
                                    double cost,
                                    int quantity,
                                    string condition)
        {
            string checkQuery = @"SELECT COUNT(*) AS DuplicateCount
                          FROM equipment 
                          WHERE equipmentName = @equipmentName 
                          AND equipmentID <> @equipmentID"; 

            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
            {
                checkCmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                checkCmd.Parameters.AddWithValue("@equipmentName", equipmentName);

                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    return false;
                }
            }

            string updateQuery = @"UPDATE equipment SET 
                           equipmentName = @equipmentName,
                           brand = @brand,
                           model = @model,
                           categoryID = @categoryID,
                           cost = @cost,
                           quantity = @quantity,
                           condition = @condition
                           WHERE equipmentID = @equipmentID";

            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
            {
                updateCmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                updateCmd.Parameters.AddWithValue("@equipmentName", equipmentName);
                updateCmd.Parameters.AddWithValue("@brand", brand);
                updateCmd.Parameters.AddWithValue("@model", model);
                updateCmd.Parameters.AddWithValue("@categoryID", categoryID);
                updateCmd.Parameters.AddWithValue("@cost", cost);
                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                updateCmd.Parameters.AddWithValue("@condition", condition);

                return updateCmd.ExecuteNonQuery() > 0;
            }
        }
        public bool BanMember(int memberID)
        {
            // SQL to update the member's status in the 'membershipStatus' column.
            string banQuery = @"UPDATE member 
                        SET membershipStatus = 'BANNED' 
                        WHERE memberID = @memberID";

            using (MySqlCommand banCmd = new MySqlCommand(banQuery, connection))
            {
                // Add the parameter for the memberID
                banCmd.Parameters.AddWithValue("@memberID", memberID);

                try
                {
                    // Execute the command and get the number of rows affected
                    int rowsAffected = banCmd.ExecuteNonQuery();

                    // Return true if the member was found and the status was updated
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log the error)
                    Console.WriteLine("Error banning member: " + ex.Message);
                    return false;
                }
            }
        }
        public bool RegisterMember(string firstName, string lastName, string middleName,
                         DateTime dob, string sex, string contactNumber,
                         string email, string membershipType)
        {
            // 1. DUPLICATE CHECK: Check if the email already exists in the 'member' table.
            string checkQuery = "SELECT COUNT(*) FROM member WHERE email = @email";

            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
            {
                checkCmd.Parameters.AddWithValue("@email", email);

                try
                {
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        // **Duplicate Found:** A record with this email already exists.
                        // We stop the process here and return false.
                        Console.WriteLine("Error: Member registration failed. Email address already in use.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database check error: " + ex.Message);
                    return false;
                }
            }
            // Set initial values
            DateTime membershipDate = DateTime.Now;
            string membershipStatus = "ACTIVE"; // Assuming new members are active

            string insertQuery = @"INSERT INTO member 
                           (lastName, firstName, middleName, DoB, Sex, contactNumber, email, 
                            membershipDate, membershipType, membershipStatus)
                           VALUES 
                           (@lastName, @firstName, @middleName, @dob, @sex, @contactNumber, @email, 
                            @membershipDate, @membershipType, @membershipStatus)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@middleName", middleName);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@membershipDate", membershipDate);
                cmd.Parameters.AddWithValue("@membershipType", membershipType);
                cmd.Parameters.AddWithValue("@membershipStatus", membershipStatus);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                    Console.WriteLine("Error registering member: " + ex.Message);
                    return false;
                }
            }
        }
        public bool UpdateMemberInfo(int memberID, string firstName, string lastName,
                             string middleName, DateTime dob, string sex,
                             string contactNumber, string email, string membershipType)
        {
            string updateQuery = @"UPDATE member SET 
                           lastName = @lastName,
                           firstName = @firstName,
                           middleName = @middleName,
                           DoB = @dob,
                           Sex = @sex,
                           contactNumber = @contactNumber,
                           email = @email,
                           membershipType = @membershipType
                           WHERE memberID = @memberID";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@middleName", middleName);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@membershipType", membershipType);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating member info: " + ex.Message);
                    return false;
                }
            }
        }
        public bool RenewMember(int memberID, string currentMembershipType)
        {
            // 1. Determine the appropriate renewal membership type
            string newMembershipType;

            switch (currentMembershipType.ToLower())
            {
                case "solo":
                    newMembershipType = "renewed solo";
                    break;
                case "group":
                    newMembershipType = "renewed group";
                    break;
                case "student":
                    newMembershipType = "renewed student";
                    break;
                case "renewed solo":
                case "renewed group":
                case "renewed student":
                    newMembershipType = currentMembershipType;
                    break;
                default:
                    Console.WriteLine($"Error: Unknown membership type provided for renewal: {currentMembershipType}");
                    return false;
            }

            // 2. Perform the database update for renewal
            DateTime renewalTime = DateTime.Now;
            string newStatus = "ACTIVE";

            // NOTE: We update the dedicated 'renewalDate' column. 
            string renewQuery = @"UPDATE members SET 
                          renewalDate = @renewalTime, 
                          membershipType = @newMembershipType,
                          membershipStatus = @newStatus
                          WHERE memberID = @memberID";

            using (MySqlCommand cmd = new MySqlCommand(renewQuery, connection))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@renewalTime", renewalTime); // Use DateTime.Now for the actual renewal time
                cmd.Parameters.AddWithValue("@newMembershipType", newMembershipType);
                cmd.Parameters.AddWithValue("@newStatus", newStatus);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error renewing member: " + ex.Message);
                    return false;
                }
            }
        }
    }
}

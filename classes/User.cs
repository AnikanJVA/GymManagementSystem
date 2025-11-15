using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        private long userID;
        private string username;
        private string password;
        private string accType;
        private long staffID;
        private string status;

        public long UserID 
        {
            get { return userID; } 
            set { userID = value; } 
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string AccType
        {
            get { return accType; }
            set { accType = value; }
        }

        public long StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        private long id;
        private string username;
        private string accType;
        private string status;

        public long Id 
        {
            get { return id; } 
            set { id = value; } 
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string AccType
        {
            get { return accType; }
            set { accType = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

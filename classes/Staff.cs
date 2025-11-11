using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public  class Staff : Person
    {
        private long staffID;
        private string schedule;
        private long positionID;
        private string address;
        private string status;

        public long StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Schedule 
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public long PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Status
        {
            get { return status; } 
            set { status = value; }
        }
    }
}

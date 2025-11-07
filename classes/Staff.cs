using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public  class Staff : User
    {
        private long staffID;
        private string lname, fname, mname;
        private string dob;
        private string sex;
        private string contactNo;
        private string email;
        private string schedule;
        private string position;

        public long StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Lname 
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Fname
        {
            get { return fname; }
            set {  fname = value; }
        }

        public string Mname 
        {
            get { return mname; }
            set {  mname = value; }
        }

        public string Dob
        {
            get { return  dob; }
            set { dob = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        public string Schedule 
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }


    }
}

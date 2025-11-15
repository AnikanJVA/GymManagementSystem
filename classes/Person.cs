using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private long id;
        private string lname;
        private string fname;
        private string mname;
        private DateTime dob;
        private string sex;
        private string contactNo;
        private string email;

        public Person()
        {
            id = 0;
            lname = string.Empty;
            fname = string.Empty;
            mname = string.Empty;
            dob = DateTime.Now;
            sex = string.Empty;
            contactNo = string.Empty;
            email = string.Empty;
        }

        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
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
    }
}

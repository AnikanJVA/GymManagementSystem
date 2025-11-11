using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Member : Person
    {
        private long memberID;
        private DateTime membershipDate;
        private DateTime renewalDate;
        private long planID;
        private string membershipStatus;

        public long MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public DateTime MembershipDate 
        {
            get { return membershipDate; }
            set { membershipDate = value; }
        }

        public DateTime RenewalDate
        {
            get { return renewalDate;  }
            set { renewalDate = value; }
        }

        public long PlanID 
        { 
            get { return planID; }
            set { planID = value; }
        }

        public string MembershipStatus
        {
            get { return membershipStatus; }
            set { membershipStatus = value; }
        }
    }
}

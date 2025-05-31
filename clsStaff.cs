using System;

namespace BusTicketBookingSystem
{
    class clsStaff
    {
        // Private fields
        private string sid, name, email, position, phone, address;
        private DateTime dob, doe;

        // Public properties
        public string StaffID
        {
            get { return sid; }
            set { sid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dob; }
            set { dob = value; }
        }

        public DateTime DateOfEmployment
        {
            get { return doe; }
            set { doe = value; }
        }
    }
}

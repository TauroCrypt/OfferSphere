using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Contact
    {
        public int ContactID { get; private set; }
        public int CustomerID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        public Contact(int contactID, int customerID, string firstName, string lastName, string email, string phoneNumber)
        {
            ContactID = contactID;
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}

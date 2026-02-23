using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string CompanyName { get; private set; }
        public string Street { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }

        public Customer(int customerID, string companyName, string street, string postalCode, string city)
        {
            CustomerID = customerID;
            CompanyName = companyName;
            Street = street;
            PostalCode = postalCode;
            City = city;
        }
    }
}

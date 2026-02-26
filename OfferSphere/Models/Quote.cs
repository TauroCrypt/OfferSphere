using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Quote
    {
        public int QuoteID { get; private set; }
        public int CustomerID { get; private set; }
        public string CompanyName { get; set; }
        public DateTime QuoteDate { get; private set; }
        public int StatusCode { get; private set; }
        public string StatusLabel { get; set; }
        public decimal TotalAmount { get; private set; }

        public Quote() { }
        public Quote(int quoteID, int customerID, string companyName, DateTime quoteDate, int statusCode, string statuslabel, decimal totalAmount)
        {
            QuoteID = quoteID;
            CustomerID = customerID;
            CompanyName = companyName;
            QuoteDate = quoteDate;
            StatusCode = statusCode;
            StatusLabel = statuslabel;
            TotalAmount = totalAmount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Quote
    {
        public int QuoteID { get; private set; }
        public int CustomerID { get; private set; }
        public DateTime QuoteDate { get; private set; }
        public int StatusCode { get; private set; }

        public Quote(int quoteID, int customerID, DateTime quoteDate, int statusCode)
        {
            QuoteID = quoteID;
            CustomerID = customerID;
            QuoteDate = quoteDate;
            StatusCode = statusCode;
        }
    }
}

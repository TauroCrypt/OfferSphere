using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class QuoteLine
    {
        public int QuoteItemID { get; set; }
        public int QuoteID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public int LineNumber { get; set; }
        public decimal UnitPrice { get; set; }

        public QuoteLine(int quoteItemID, int quoteID, int serviceID, int quantity, int lineNumber, decimal unitPrice)
        {
            QuoteItemID = quoteItemID;
            QuoteID = quoteID;
            ServiceID = serviceID;
            Quantity = quantity;
            LineNumber = lineNumber;
            UnitPrice = unitPrice;
        }
    }
}

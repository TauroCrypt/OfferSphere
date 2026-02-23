using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Invoice
    {
        public int InvoiceID { get; private set; }
        public int QuoteID { get; private set; }
        public string InvoiceNumber { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public int TermCode { get; private set; }
        public int StatusCode { get; private set; }

        public Invoice(int invoiceID, int quoteID, string invoiceNumber, DateTime invoiceDate, int termCode, int statusCode)
        {
            InvoiceID = invoiceID;
            QuoteID = quoteID;
            InvoiceNumber = invoiceNumber;
            InvoiceDate = invoiceDate;
            TermCode = termCode;
            StatusCode = statusCode;
        }
    }
}

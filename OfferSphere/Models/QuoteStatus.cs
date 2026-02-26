using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class QuoteStatus
    {
        public int StatusCode { get; set; }
        public string Label { get; set; }

        public QuoteStatus() { }
        public QuoteStatus(int statusCode, string label)
        {
            StatusCode = statusCode;
            Label = label;
        }
    }
}

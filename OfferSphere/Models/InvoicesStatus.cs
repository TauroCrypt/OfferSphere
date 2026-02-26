using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class InvoicesStatus
    {
        public int StatusCode { get; set; }
        public string Label { get; set; }

        public InvoicesStatus() { }
        public InvoicesStatus(int statusCode, string label)
        {
            StatusCode = statusCode;
            Label = label;
        }
    }
}

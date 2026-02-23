using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class PaymentTerm
    {
        public int TermCode { get; private set; }
        public string Label { get; private set; }
        public int NetDays { get; private set; }

        public PaymentTerm(int termCode, string label, int netDays)
        {
            TermCode = termCode;
            Label = label;
            NetDays = netDays;
        }
    }
}

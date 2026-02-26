using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class ServiceCategory
    {
        public int CategoryCode { get; private set; }
        public string Label { get; private set; }

        public ServiceCategory() { }
        public ServiceCategory(int categoryCode, string label)
        {
            CategoryCode = categoryCode;
            Label = label;
        }
    }
}

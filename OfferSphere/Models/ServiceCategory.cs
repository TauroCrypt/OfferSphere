using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class ServiceCategory
    {
        public int CategoryCode { get; set; }
        public string Label { get; set; }

        public ServiceCategory() { }
        public ServiceCategory(int categoryCode, string label)
        {
            CategoryCode = categoryCode;
            Label = label;
        }
    }
}

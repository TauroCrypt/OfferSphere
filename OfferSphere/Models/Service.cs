using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Models
{
    public class Service
    {
        public int ServiceID { get; private set; }
        public string ServiceName { get; private set; }
        public string Description { get; private set; }
        public int CategoryCode { get; private set; }
        public decimal CurrentPrice { get; private set; }

        public Service() { }
        public Service(int serviceID, string serviceName, string description, int categoryCode, decimal currentPrice)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            Description = description;
            CategoryCode = categoryCode;
            CurrentPrice = currentPrice;
        }
    }
}

using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Views
{
    public class ServiceViewModel
    {
        private ServiceRepository _repository;
        public List<Service> Services { get; set; }

        public ServiceViewModel()
        {
            _repository = new ServiceRepository();
            //Services = _repository.GetAllServices();
        }
    }
}

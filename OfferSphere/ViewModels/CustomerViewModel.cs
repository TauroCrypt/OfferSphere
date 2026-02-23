using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OfferSphere.Views
{
    public class CustomerViewModel
    {
        private CustomerRepository _repository;
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            _repository = new CustomerRepository();
            Customers = _repository.GetAllCustomers();
        }
    }
}

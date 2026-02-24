using OfferSphere.Commands;
using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace OfferSphere.Views
{
    public class CustomerViewModel
    {
        private CustomerRepository _repository;
        public ICommand AddCustomerCommand { get;}
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            _repository = new CustomerRepository();
            AddCustomerCommand = new RelayCommand(AddCostumer);
            Customers = _repository.GetAllCustomers();
        }

        private void AddCostumer()
        {
            MessageBox.Show($"Angekommen");
        }

    }
}

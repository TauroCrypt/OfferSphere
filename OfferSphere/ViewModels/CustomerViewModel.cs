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
        public ICommand EditCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            _repository = new CustomerRepository();
            AddCustomerCommand = new RelayCommand(AddCostumer);
            EditCustomerCommand = new RelayCommand(EditCustomer);
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            Customers = _repository.GetAllCustomers();
        }

        private void AddCostumer()
        {
            MessageBox.Show("Add Costumer functionality is not implemented yet.");
        }

        private void EditCustomer()
        {
            MessageBox.Show("Edit Costumer functionality is not implemented yet.");
        }

        private void DeleteCustomer()
        {
            MessageBox.Show("Delete Costumer functionality is not implemented yet.");
        }

    }
}

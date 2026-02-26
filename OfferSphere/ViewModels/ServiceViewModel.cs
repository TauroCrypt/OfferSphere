using OfferSphere.Commands;
using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace OfferSphere.Views
{
    public class ServiceViewModel
    {
        private ServiceRepository _repository;
        public List<Service> Services { get; set; }
        public List<ServiceCategory> ServiceCategoryFilter { get; set; }
        public ICommand CreateServiceCommand { get; }
        public ICommand EditServiceCommand { get; }
        public ICommand DeleteServiceCommand { get; }

        public ServiceViewModel()
        {
            _repository = new ServiceRepository();
            CreateServiceCommand = new RelayCommand(CreateService);
            EditServiceCommand = new RelayCommand(EditService);
            DeleteServiceCommand = new RelayCommand(DeleteService);
            ServiceCategoryFilter = _repository.GetAllCategories();
            ServiceCategoryFilter.Insert(0, new ServiceCategory { Label = "All" });
            Services = _repository.GetAllServices();
        }

        public void CreateService()
        {
            MessageBox.Show("Add Service functionality is not implemented yet.");
        }

        public void EditService()
        {
            MessageBox.Show("Edit Service functionality is not implemented yet.");
        }

        public void DeleteService()
        {
            MessageBox.Show("Delete Service functionality is not implemented yet.");
        }
    }
}

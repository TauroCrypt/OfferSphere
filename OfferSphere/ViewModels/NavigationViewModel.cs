using OfferSphere.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using OfferSphere.Services;
using System.Security.Cryptography.Pkcs;

namespace OfferSphere.Views
{
    public class NavigationViewModel
    {
        private readonly NavigationService _navigationService;
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowServicesCommand { get; }
        public ICommand ShowQuotesCommand { get; }
        public ICommand ShowInvoicesCommand { get; }

        public NavigationViewModel(NavigationService navigationService)
        {
            _navigationService = navigationService;
            ShowCustomersCommand = new RelayCommand(ShowCustomers);
            ShowServicesCommand = new RelayCommand(ShowServices);
            ShowQuotesCommand = new RelayCommand(ShowQuotes);
            ShowInvoicesCommand = new RelayCommand(ShowInvoices);
        }

        private void ShowCustomers()
        {
            _navigationService.Navigate("Views/CustomersView.xaml");
        }
        private void ShowServices()
        {
            _navigationService.Navigate("Views/ServicesView.xaml");
        }
        private void ShowQuotes()
        {
            _navigationService.Navigate("Views/QuotesView.xaml");
        }
        private void ShowInvoices()
        {
            _navigationService.Navigate("Views/InvoicesView.xaml");
        }
    }
}

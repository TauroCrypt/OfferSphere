using OfferSphere.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using OfferSphere.Services;

namespace OfferSphere.Views
{
    public class MainViewModel
    {
        public NavigationViewModel Navigation { get; }
        public MainViewModel Main { get; }
        public ICommand OpenSettingsCommand { get; }
        public ICommand OpenHelpCommand { get; }

        public MainViewModel(NavigationService navigationService)
        {
            Navigation = new NavigationViewModel(navigationService);
            OpenSettingsCommand = new RelayCommand(OpenSettings);
            OpenHelpCommand = new RelayCommand(OpenHelp);
        }

        private void OpenSettings()
        {
            System.Windows.MessageBox.Show("Settings functionality is not implemented yet.");
        }

        private void OpenHelp()
        {
            System.Windows.MessageBox.Show("Help functionality is not implemented yet.");
        }
    }
}

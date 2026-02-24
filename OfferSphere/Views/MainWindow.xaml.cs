using OfferSphere.Data;
using OfferSphere.Views;
using System.Data.OleDb;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using OfferSphere.Services;
using System.Windows.Shapes;

namespace OfferSphere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            var navigationService = new NavigationService(MainFrame);
            _viewModel = new NavigationViewModel(navigationService);

            DataContext = _viewModel;
        }
    }
}
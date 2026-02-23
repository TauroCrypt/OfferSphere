using OfferSphere.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OfferSphere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Perform database operations here
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(new Uri("Views\\CustomersView.xaml", UriKind.Relative));
        }
    }
}
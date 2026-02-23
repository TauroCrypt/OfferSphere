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
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if(clickedButton is null)
                    throw new InvalidOperationException("Der angeklickte Button ist null.");

                string tagWert = clickedButton.Tag.ToString();

                switch (tagWert)
                {
                    case "btn_MenuCustomers":
                        MainFrame.Navigate(new Uri("Views\\CustomersView.xaml", UriKind.Relative));
                        break;
                    case "btn_MenuService":
                        MainFrame.Navigate(new Uri("Views\\ServicesView.xaml", UriKind.Relative));
                        break;
                    case "btn_MenuQuote":
                        MainFrame.Navigate(new Uri("Views\\QuotesView.xaml", UriKind.Relative));
                        break;
                    case "btn_MenuInvoice":
                        MainFrame.Navigate(new Uri("Views\\InvoicesView.xaml", UriKind.Relative));
                        break;
                    default:
                        MessageBox.Show("Unbekannte Aktion");
                        break;
                }
            }
        }
    }
}
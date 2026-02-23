using System;
using System.Collections.Generic;
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

namespace OfferSphere.Views
{
    /// <summary>
    /// Interaktionslogik für InvoicesView.xaml
    /// </summary>
    public partial class InvoicesView : UserControl
    {
        private InvoiceViewModel _viewModel;
        public InvoicesView()
        {
            InitializeComponent();

            _viewModel = new InvoiceViewModel();
            DataContext = _viewModel;
        }
    }
}

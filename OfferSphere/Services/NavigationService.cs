using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace OfferSphere.Services
{
    public class NavigationService
    {
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
        }

        public void Navigate(string view)
        {
            _frame.Navigate(new Uri(view, UriKind.Relative));
        }
    }
}

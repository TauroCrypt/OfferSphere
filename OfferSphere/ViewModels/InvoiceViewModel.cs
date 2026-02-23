using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Views
{
    public class InvoiceViewModel
    {
        private InvoiceRepository _repository;
        public List<Invoice> Invoices { get; set; }

        public InvoiceViewModel()
        {
            _repository = new InvoiceRepository();
            //Invoices = _repository.GetAllInvoices();
        }
    }
}

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
    public class QuoteViewModel
    {
        private QuoteRepository _repository;
        public List<Quote> Quotes { get; set; }
        public List<QuoteStatus> QuoteStatusFilter { get; set; }
        public ICommand CreateQuoteCommand { get; }
        public ICommand OpenQuoteCommand { get; }
        public ICommand EditQuoteCommand { get; }
        public ICommand SendQuoteCommand { get; }
        public ICommand DeleteQuoteCommand { get; }

        public QuoteViewModel()
        {
            _repository = new QuoteRepository();
            CreateQuoteCommand = new RelayCommand(CreateQuote);
            OpenQuoteCommand = new RelayCommand(OpenQuote);
            EditQuoteCommand = new RelayCommand(EditQuote);
            SendQuoteCommand = new RelayCommand(SendQuote);
            DeleteQuoteCommand = new RelayCommand(DeleteQuote);

            QuoteStatusFilter = _repository.GetAllQuoteStatuses();
            QuoteStatusFilter.Insert(0, new QuoteStatus { Label = "All" });
            Quotes = _repository.GetAllQuotes();
        }

        private void OpenQuote()
        {
            MessageBox.Show("Open Quote functionality is not implemented yet.");
        }

        private void CreateQuote()
        {
            MessageBox.Show("Create Quote functionality is not implemented yet.");
        }

        private void EditQuote()
        {
            MessageBox.Show("Edit Quote functionality is not implemented yet.");
        }

        private void DeleteQuote()
        {
            MessageBox.Show("Delete Quote functionality is not implemented yet.");
        }

        private void SendQuote()
        {
            MessageBox.Show("Send Quote functionality is not implemented yet.");
        }
    }
}

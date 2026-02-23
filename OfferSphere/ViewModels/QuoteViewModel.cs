using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Views
{
    public class QuoteViewModel
    {
        private QuoteRepository _repository;
        public List<Quote> Quotes { get; set; }

        public QuoteViewModel()
        {
            _repository = new QuoteRepository();
            //Quotes = _repository.GetAllQuotes();
        }
    }
}

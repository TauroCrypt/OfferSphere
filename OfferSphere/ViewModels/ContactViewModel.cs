using OfferSphere.Data;
using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfferSphere.Views
{
    public class ContactViewModel
    {
        private ContactRepository _repository;
        public List<Contact> Contacts { get; set; }

        public ContactViewModel()
        {
            _repository = new ContactRepository();
            //Customers = _repository.GetAllContacts();
        }
    }
}

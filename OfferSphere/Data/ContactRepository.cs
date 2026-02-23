using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace OfferSphere.Data
{
    public class ContactRepository
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;

        public ContactRepository() { }

        public List<Contact> GetAllContactTypes()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<Contact> contacts = new List<Contact>();

            string query = "SELECT * FROM contactTypes";
            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                contacts.Add(new Contact
                (
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                ));
            }

            dbConnection.Close();
            return contacts;
        }
    }
}

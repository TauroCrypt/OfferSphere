using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace OfferSphere.Data
{
    public class InvoiceRepository
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;

        public InvoiceRepository() { }

        public List<Invoice> GetAllInvoices()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<Invoice> invoices = new List<Invoice>();

            string query = "SELECT * FROM invoices";
            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                invoices.Add(new Invoice
                (
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetInt32(4),
                    reader.GetInt32(5)
                ));
            }

            dbConnection.Close();
            return invoices;
        }
    }
}

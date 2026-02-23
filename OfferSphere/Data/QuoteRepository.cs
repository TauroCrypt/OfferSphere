using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;

namespace OfferSphere.Data
{
    public class QuoteRepository
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;

        public QuoteRepository() { }

        public List<Quote> GetAllQuotes()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<Quote> quotes = new List<Quote>();

            string query = "SELECT * FROM quotes";

            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                quotes.Add(new Quote
                (
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetDateTime(2),
                    reader.GetInt32(3)
                ));
            }

            dbConnection.Close();

            return quotes;
        }
    }
}

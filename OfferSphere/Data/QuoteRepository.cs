using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;
using System.Windows;

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

            string query = "SELECT q.quoteID, c.customerID, c.companyname, q.quoteDate, qs.statusCode, qs.label, (SELECT SUM(ql.unitPrice) FROM quoteLine AS ql WHERE ql.quoteID = q.quoteID) AS totalAmount FROM (quotes AS q LEFT JOIN customers AS c ON q.customerID = c.customerID) LEFT JOIN quoteStatus AS qs ON q.statusCode = qs.statusCode;";

            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                quotes.Add(new Quote
                (
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetInt32(4),
                    reader.GetString(5),
                    reader.GetDecimal(6)
                ));
            }

            dbConnection.Close();

            return quotes;
        }

        public List<QuoteStatus> GetAllQuoteStatuses()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<QuoteStatus> statuses = new List<QuoteStatus>();
            string query = "SELECT * FROM quoteStatus;";
            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statuses.Add(new QuoteStatus
                (
                    reader.GetInt32(0),
                    reader.GetString(1)
                ));
            }
            dbConnection.Close();
            return statuses;
        }

        public Quote GetQuoteById(int quoteId)
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            Quote quote = null;
            string query = "SELECT q.quoteID, c.customerID, c.companyname, q.quoteDate, qs.statusCode, qs.label, (SELECT SUM(ql.unitPrice) FROM quoteLine AS ql WHERE ql.quoteID = q.quoteID) AS totalAmount FROM (quotes AS q LEFT JOIN customers AS c ON q.customerID = c.customerID) LEFT JOIN quoteStatus AS qs ON q.statusCode = qs.statusCode WHERE q.quoteID = @quoteId;";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@quoteId", quoteId);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                quote = new Quote
                (
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetInt32(4),
                    reader.GetString(5),
                    reader.GetDecimal(6)
                );
            }
            dbConnection.Close();
            return quote;
        }
    }
}

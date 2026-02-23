using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Dynamic;
using System.Text;
using System.Windows;

namespace OfferSphere.Data
{
    internal class CustomerRepositoy
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;
        public CustomerRepositoy() { }

        public List<string> GetAllCustomers()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<string> results = new List<string>();

            string sql = "SELECT companyName FROM customers";

            cmd = new OleDbCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                results.Add(reader.GetString(0));
            }

            dbConnection.Close();

            return results;
        }

        public void GetCustomerFromID(int id)
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;

            string sql = "SELECT companyName FROM customers WHERE customerID = ?";
            
            cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("?", id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(0));
            }

            dbConnection.Close();
        }
    }
}

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
        public CustomerRepositoy() { }

        public void GetCustomerFromID(int id)
        {
            DBConnection dbConnection = new DBConnection();
            OleDbConnection conn = dbConnection.Connection;
            OleDbCommand cmd;
            OleDbDataReader reader;

            dbConnection.Open();

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

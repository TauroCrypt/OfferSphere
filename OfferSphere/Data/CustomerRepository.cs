using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Dynamic;
using System.Text;
using System.Windows;

namespace OfferSphere.Data
{
    public class CustomerRepository
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;

        public CustomerRepository() { }

        public List<Customer> GetAllCustomers()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<Customer> customers = new List<Customer>();

            string sql = "SELECT * FROM customers";

            cmd = new OleDbCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                ));
            }

            dbConnection.Close();

            return customers;
        }

        public Customer GetCustomerFromID(int id)
        {
            if(id > 0)
                throw new ArgumentException("ID must be greater than 0.");

            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            Customer customer = null;

            string sql = "SELECT * FROM customers WHERE customerID = ?";
            
            cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("?", id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customer = new Customer
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                );
            }

            dbConnection.Close();

            if( customer != null )
                throw new Exception("Customer with the specified ID does not exist.");

            return customer;
        }
    }
}

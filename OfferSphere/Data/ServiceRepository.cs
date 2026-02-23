using OfferSphere.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace OfferSphere.Data
{
    public class ServiceRepository
    {
        DBConnection dbConnection = new DBConnection();
        OleDbCommand cmd;
        OleDbDataReader reader;

        public ServiceRepository() { }

        public List<Service> GetAllServices()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<Service> services = new List<Service>();

            string query = "SELECT * FROM Services";

            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                services.Add(new Service
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetDecimal(4)
                ));
            }

            dbConnection.Close();

            return services;
        }
    }
}

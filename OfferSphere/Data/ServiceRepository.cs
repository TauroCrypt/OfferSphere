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

            string query = "SELECT s.serviceID, s.serviceName, s.description, sc.categoryCode, sc.label, s.currentPrice FROM Services s LEFT JOIN serviceCategories sc ON s.categoryCode = sc.categoryCode";

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
                    reader.GetString(4),
                    reader.GetDecimal(5)
                ));
            }

            dbConnection.Close();

            return services;
        }

        public List<ServiceCategory> GetAllCategories()
        {
            dbConnection.Open();
            OleDbConnection conn = dbConnection.Connection;
            List<ServiceCategory> categories = new List<ServiceCategory>();
            string query = "SELECT * FROM serviceCategories;";
            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new ServiceCategory
                (
                    reader.GetInt32(0),
                    reader.GetString(1)
                ));
            }
            dbConnection.Close();
            return categories;
        }

        public Service GetServiceById(int id)
        {
            Service service = null;
            return service;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows;

namespace OfferSphere.Data
{
    public class DBConnection
    {
        private string ConnectionString { get; set; }
        public OleDbConnection Connection { get; private set; }

        public DBConnection()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            
            DirectoryInfo dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null && !dir.Name.Equals("bin", StringComparison.OrdinalIgnoreCase))
            {
                dir = dir.Parent;
            }

            string projectDir = (dir?.Parent != null) ? dir.Parent.FullName : AppContext.BaseDirectory;
            string dbPath = Path.Combine(projectDir, @"Database\OfferSphereDB.accdb");

            ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
            Connection = new OleDbConnection(ConnectionString);
        }
        public void Open()
        {
            Connection.Open();
        }
        public void Close()
        {
            Connection.Close();
        }
    }
}

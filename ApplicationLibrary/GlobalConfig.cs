using ApplicationLibrary.DataAccess;
using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;

namespace ApplicationLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
       
        public static void InitializeConnections(DatabaseType dbType)
        {
            switch (dbType)
            {
                case DatabaseType.MySql:
                    MySqlConnector mySqlConnector = new MySqlConnector();
                    Connection = mySqlConnector;
                    break;
                default:
                    break;
            }
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

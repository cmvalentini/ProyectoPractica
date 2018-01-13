using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer.Connection
{
    public class Configuration
    {
        public static string GetConString(string dbName)
        {
           return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }
    }
}

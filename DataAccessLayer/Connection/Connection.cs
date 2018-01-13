using Connection.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.Connection
{
    public class Connection : IConnection
    {
        public IDbConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(Configuration.GetConString("DB"));
        }
    }
}

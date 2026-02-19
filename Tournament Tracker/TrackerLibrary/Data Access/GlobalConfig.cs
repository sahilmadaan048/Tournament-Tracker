using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using Microsoft.Extensions.Configuration;

namespace TrackerLibrary.DataAccess
{
    public static class GlobalConfig
    {
        public static IConfiguration Configuration { get; private set; }
        //public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db, IConfiguration config)
        {
            Configuration = config;

            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return Configuration.GetConnectionString(name);
        }
    }
}

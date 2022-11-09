using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace work
{
    class Class2
    {
        public static MySqlConnection GetSqlConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "mlpnko";
            string user = "root";
            string password = "Mlpnko1357246";

            return Class1.GetSqlConnection(host, port, database, user, password);
        }
    }
}

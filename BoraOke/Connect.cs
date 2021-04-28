using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BoraOke
{
    public class Connect
    {
        static string connectionString = "server=localhost; port=3306; uid=Agnes108;" + "pwd=110801as; database=dataalbum; charset=utf8; sslMode=none;";
        static MySqlConnection connection = new MySqlConnection(connectionString);

        public MySqlConnection Connection
        {
            get { return connection; }
        }
    }
}

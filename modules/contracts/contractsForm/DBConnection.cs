using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace contractsForm
{
    internal class DBConnection
    {
        string strConn =
                @"Data Source=localhost;
          Initial Catalog=QLHOPDONG;
          Integrated Security=True;
          TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(strConn);
        }
    }
}

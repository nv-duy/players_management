using System.Data.SqlClient;

namespace players_management.DATA
{
    internal class DBConnection
    {
        string strConn =
            @"Data Source=.\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0"
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strConn);
        }
    }
}
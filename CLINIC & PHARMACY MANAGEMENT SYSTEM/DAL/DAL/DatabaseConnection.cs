using System.Data.SqlClient;

namespace ClinicSystem.DAL
{
    public class DatabaseConnection
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

using System.Data.SqlClient;

namespace GraphQl.Api.Services
{
    public class DbConnection :IConnection
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;
        public DbConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public SqlConnection DatabaseConnection()
        {
            return new SqlConnection(_connectionString);
        }


    }
}

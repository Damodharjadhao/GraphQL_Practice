using System.Data.SqlClient;

namespace GraphQl.Api.Services
{
    public interface IConnection
    {
        public SqlConnection DatabaseConnection();
    }
}

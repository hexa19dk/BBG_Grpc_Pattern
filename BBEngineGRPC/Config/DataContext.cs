using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace BBEngineGRPC.Config
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions options) : base(options) { }

        private readonly IConfiguration _configuration;
        private readonly string _connString;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connString = _configuration.GetConnectionString("connect");
        }

        public IDbConnection Connection() => new SqlConnection(_connString);
    }
}

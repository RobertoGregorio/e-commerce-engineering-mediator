using e_commerce_engineering.domain.Interfaces;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Data;
using System.Data.Common;

namespace e.commerce.egineering.infrastructure.Data
{
    public class DbConnectionManager(IConfiguration configuration) : IDbConnectionManager
    {
        private readonly IConfiguration configuration = configuration;

        private MySqlConnection current_dbConnection;

        public DbConnection GetConnection()
        {
            current_dbConnection ??= current_dbConnection = new MySqlConnection(connectionString: configuration.GetConnectionString("DefaultConnection"));

            if (current_dbConnection.State is not ConnectionState.Open)
                current_dbConnection.Open();

            return current_dbConnection;
        }

        public void Dispose()
        {
            if (current_dbConnection is not null)
            {
                current_dbConnection.Close();
                current_dbConnection?.Dispose();
            }
        }
    }
}

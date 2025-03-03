using System.Data.Common;

namespace e_commerce_engineering.domain.Interfaces;

public interface IDbConnectionManager
{
    public DbConnection GetConnection();
}

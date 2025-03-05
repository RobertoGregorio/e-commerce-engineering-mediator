using e.commerce.engineering.domain.Aggregates.UserAggregates;

namespace e.commerce.engineering.domain.Repositorys
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
    }
}

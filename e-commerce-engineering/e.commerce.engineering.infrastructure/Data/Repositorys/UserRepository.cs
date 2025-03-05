using e.commerce.engineering.domain.Aggregates.UserAggregates;
using e.commerce.engineering.domain.Repositorys;
using e.commerce.egineering.infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace e.commerce.egineering.infrastructure.Data.Repositorys
{
    public class UserRepository(ApplicationDbContext applicationDbContext) : Repository<User>(applicationDbContext), IUserRepository
    {
        public async Task<User> GetUserByUsername(string username)
        {
            return await applicationDbContext.Users.FirstOrDefaultAsync(user => user.Username == username);
        }
    }
}

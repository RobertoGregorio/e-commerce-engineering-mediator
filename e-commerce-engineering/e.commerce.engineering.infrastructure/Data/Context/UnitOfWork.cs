using e.commerce.engineering.domain.Repositorys;

namespace e.commerce.egineering.infrastructure.Data.Context
{
    public class UnitOfWork(ApplicationDbContext applicationDbContext) : IUnitOfWork
    {
        public void Commit() => applicationDbContext.SaveChanges();

        public async void CommitAsync() => await applicationDbContext.SaveChangesAsync();

    }
}

using e_commerce_engineering.domain.Repositorys;

namespace e_commerce_egineering.infrastructure.Data.Context
{
    public class UnitOfWork(ApplicationDbContext applicationDbContext) : IUnitOfWork
    {
        public readonly ApplicationDbContext applicationDbContext = applicationDbContext;

        public void Commit() => applicationDbContext.SaveChanges();

        public async void CommitAsync() => await applicationDbContext.SaveChangesAsync();

    }
}

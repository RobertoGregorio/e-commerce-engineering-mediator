namespace e_commerce_egineering.infrastructure.Data.Context
{
    internal class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }
    }
}

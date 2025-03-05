using e.commerce.egineering.infrastructure.Data.Repositorys;
using e.commerce.engineering.domain.Repositorys;

namespace e.commerce.egineering.infrastructure.Data.Context
{
    public class UnitOfWork(ApplicationDbContext applicationDbContext) : IUnitOfWork
    {
        private  IUserRepository userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                this.userRepository ??= new UserRepository(applicationDbContext);
                return userRepository;
            }
           
        }

        public int MyProperty { get; set; }

        public void Commit() => applicationDbContext.SaveChanges();

        public async void CommitAsync() => await applicationDbContext.SaveChangesAsync();

    }
}

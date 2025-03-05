namespace e.commerce.engineering.domain.Repositorys
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        public void Commit();
        public void CommitAsync();
    }
}

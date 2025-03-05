namespace e_commerce_engineering.domain.Repositorys
{
    public interface IUnitOfWork
    {
        public void Commit();
        public void CommitAsync();
    }
}

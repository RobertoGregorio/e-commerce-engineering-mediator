namespace e.commerce.engineering.domain.Repositorys
{
    public interface IUnitOfWork
    {

        public void Commit();
        public void CommitAsync();
    }
}

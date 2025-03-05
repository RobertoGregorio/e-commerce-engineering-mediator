namespace e_commerce_engineering.domain.Repositorys;

public interface IRepository<T> where T : class
{
    public void AddAsync(T entity);
    public void Delete(T entity);
    public Task<T?> GetByIdAsync(int id);
    public IQueryable<T> GetAllQueryable(int pageSize, int pageIndex);
    public Task<IEnumerable<T>> GetAll(int pageSize, int pageIndex);
    public void UpdateAsync(T entity);

}
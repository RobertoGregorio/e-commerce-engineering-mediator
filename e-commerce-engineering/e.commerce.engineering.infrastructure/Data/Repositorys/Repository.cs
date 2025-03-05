using e_commerce_egineering.infrastructure.Data.Context;
using e_commerce_engineering.domain.Repositorys;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace e_commerce_egineering.infrastructure.Data.Repositorys
{
    public class Repository<T>(UnitOfWork unitOfWork) : IRepository<T> where T : class
    {
        private readonly UnitOfWork UnitOfWork = unitOfWork;

        private readonly CancellationToken cancellationToken;

        public async void AddAsync(T entity) => await UnitOfWork.applicationDbContext.Set<T>().AddAsync(entity);

        public void Delete(T entity) => UnitOfWork.applicationDbContext.Set<T>().Remove(entity);

        public async Task<IEnumerable<T>> GetAll(int pageSize, int pageIndex) => await UnitOfWork.applicationDbContext.Set<T>().Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

        public IQueryable<T> GetAllQueryable(int pageSize, int pageIndex) => UnitOfWork.applicationDbContext.Set<T>().Skip(pageSize * pageIndex).Take(pageSize);

        public async Task<T?> GetByIdAsync(int id)
        {
            var propertyName = typeof(T).Name + nameof(id);
            var property = typeof(T).GetProperty(propertyName) ?? throw new InvalidCastException($"Property {propertyName} not found");

            Expression<Func<T, bool>> predicateQueryFilter = (entityInstance => Convert.ToInt32(property.GetValue(entityInstance)) == id);
            var result = await UnitOfWork.applicationDbContext.Set<T>().FirstOrDefaultAsync(predicateQueryFilter, cancellationToken);

            return result;
        }

        public void UpdateAsync(T entity) => UnitOfWork.applicationDbContext.Set<T>().Update(entity);

    }
}

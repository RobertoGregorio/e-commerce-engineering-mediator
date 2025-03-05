using e.commerce.engineering.domain.Repositorys;
using e.commerce.egineering.infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace e.commerce.egineering.infrastructure.Data.Repositorys
{
    public class Repository<T>(ApplicationDbContext applicationDbContext) : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext applicationDbContext = applicationDbContext;

        private readonly CancellationToken cancellationToken;

        public async void AddAsync(T entity) => await this.applicationDbContext.Set<T>().AddAsync(entity);

        public void Delete(T entity) => this.applicationDbContext.Set<T>().Remove(entity);

        public async Task<IEnumerable<T>> GetAll(int pageSize, int pageIndex) => await this.applicationDbContext.Set<T>().Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

        public IQueryable<T> GetAllQueryable(int pageSize, int pageIndex) => this.applicationDbContext.Set<T>().Skip(pageSize * pageIndex).Take(pageSize);

        public async Task<T?> GetByIdAsync(int id)
        {
            var propertyName = typeof(T).Name + nameof(id);
            var property = typeof(T).GetProperty(propertyName) ?? throw new InvalidCastException($"Property {propertyName} not found");

            Expression<Func<T, bool>> predicateQueryFilter = (entityInstance => Convert.ToInt32(property.GetValue(entityInstance)) == id);
            var result = await this.applicationDbContext.Set<T>().FirstOrDefaultAsync(predicateQueryFilter, cancellationToken);

            return result;
        }

        public void UpdateAsync(T entity) => this.applicationDbContext.Set<T>().Update(entity);

    }
}

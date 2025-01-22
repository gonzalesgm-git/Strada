using Strada.Domain.Models;

namespace Strada.Database.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> Query();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

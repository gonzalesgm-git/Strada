using Microsoft.EntityFrameworkCore;
using Strada.Domain.Models;

namespace Strada.Database.Repositories
{
    public  class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private StradaDbContext Context { get; }
        protected DbSet<T> Set => Context.Set<T>();
        protected Repository(StradaDbContext context) => Context = context;

        public IQueryable<T> Query() => Set;

        public void Add(T entity)
        {
            Set.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            Set.Update(entity);
            Save();
        }

        public void Delete(T entity) => Set.Remove(entity);

        private void Save()
        {
            Context.SaveChanges();
        }

    }
}

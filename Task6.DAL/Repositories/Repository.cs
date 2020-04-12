using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Task6.DAL.Interfaces;

namespace Task6.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MyDbContext db;
        private DbSet<T> entities;

        public Repository(MyDbContext db)
        {
            this.db = db;
            entities = db.Set<T>();
        }

        public void Add(T item)
        {
            entities.Add(item);
        }

        public void Delete(int id)
        {
            T entity = entities.Find(id);
            if (entity != null)
                entities.Remove(entity);
        }

        public T Get(int id)
        {
            return entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
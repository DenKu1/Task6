using System;
using Task6.DAL.Entities;
using Task6.DAL.Interfaces;

namespace Task6.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext context;
        private Repository<Product> products;
        private Repository<Order> orders;

        public UnitOfWork()
        {
            context = new MyDbContext();
        }

        public Repository<Product> Products =>
            products ?? (products = new Repository<Product>(context));
        public Repository<Order> Orders =>
            orders ?? (orders = new Repository<Order>(context));
      
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

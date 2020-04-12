using System;
using Task6.DAL.Entities;
using Task6.DAL.Repositories;

namespace Task6.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Product> Products { get; }
        Repository<Order> Orders { get; }
        void Save();
    }
}
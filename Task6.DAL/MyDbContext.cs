using System.Data.Entity;
using Task6.DAL.Entities;

namespace Task6.DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        static MyDbContext()
        {
            Database.SetInitializer(new MyDbInitializer());
        }
    }
}

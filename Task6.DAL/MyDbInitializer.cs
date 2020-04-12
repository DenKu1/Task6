using System.Collections.Generic;
using System.Data.Entity;
using Task6.DAL.Entities;

namespace Task6.DAL
{
    class MyDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext db)
        {
            Product p1 = new Product { Name = "Phone", Price = 200 };
            Product p2 = new Product { Name = "Keyboard", Price = 50 };
            Product p3 = new Product { Name = "Monitor", Price = 500 };
            Product p4 = new Product { Name = "Tablet", Price = 350 };

            Order o1 = new Order { Products = new List<Product> { p1, p2, p3} };
            Order o2 = new Order { Products = new List<Product> {  } };
            Order o3 = new Order { Products = new List<Product> { p3 } };
            Order o4 = new Order { Products = new List<Product> { p1, p4 } };

            db.Products.AddRange(new List<Product>{ p1, p2, p3, p4});
            db.Orders.AddRange(new List<Order> { o1, o2, o3, o4 });
            
            db.SaveChanges();
        }
    }
}

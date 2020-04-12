using System.Collections.Generic;

namespace Task6.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public virtual List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task6.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual List<Order> Orders { get; set; }

        public Product()
        {
            Orders = new List<Order>();
        }
    }
}
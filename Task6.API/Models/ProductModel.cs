using System.ComponentModel.DataAnnotations;

namespace Task6.API.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Укажите id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Укажите цену")]
        public decimal Price { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Task6.API.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "Укажите id")]
        public int Id { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        // thuộc tính khoá ngoài
        public int CustomerId { get; set; }

        // thuộc tính điều hướng
        public virtual Customer Customer { get; set; }
    }
}
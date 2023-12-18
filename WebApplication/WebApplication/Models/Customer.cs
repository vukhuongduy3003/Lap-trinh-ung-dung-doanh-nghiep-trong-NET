using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        // Thuộc tính điều hướng
        public virtual ICollection<Order> orders { get; set; }
    }
}
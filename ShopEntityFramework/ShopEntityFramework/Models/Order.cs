using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramework.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        // khoá ngoài
        public int CustomerId { get; set; }

        // thuộc tính điều hướng
        public virtual Customer Customer { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShopEntityFramework.Models;
using EntityFramework.Models;

namespace ShopEntityFramework.App_Start
{
    public class MyDBInit : DropCreateDatabaseIfModelChanges<DataModel>
    {
        protected override void Seed(DataModel context)
        {
            //context.Customers.Add(new Customer { CustomerId = 1, Name = "Vũ" });
            //context.Customers.Add(new Customer { CustomerId = 2, Name = "Khương" });
            //context.Customers.Add(new Customer { CustomerId = 3, Name = "Duy" });
            ////context.Orders.Add(new Order { CustomerId = 1, ProductName = "Bánh mỳ", Price = 10000, Quantity = 2 });
            ////context.Orders.Add(new Order { CustomerId = 2, ProductName = "Mỳ tôm", Price = 5000, Quantity = 1 });
            //context.SaveChanges();
            ////base.Seed(context);
            var customer = new Customer { CustomerId = 1, Name = "Vũ" };
            context.Customers.Add(customer);
            Console.WriteLine(context.Entry(customer).State); // In trạng thái của đối tượng
            context.SaveChanges();
        }
    }
}
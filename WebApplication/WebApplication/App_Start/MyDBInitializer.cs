using System.Data.Entity;
using WebApplication.Models;

namespace WebApplication.App_Start
{
    public class MyDBInitializer : DropCreateDatabaseIfModelChanges<ShopDataContext>
    {
        protected override void Seed(ShopDataContext context)
        {
            context.Customers.Add(new Customer { CustomerId = 1, Name = "Duy" });
            context.Customers.Add(new Customer { CustomerId = 2, Name = "Khương" });
            context.Customers.Add(new Customer { CustomerId = 3, Name = "Vũ" });
            context.SaveChanges();
            context.Orders.Add(new Order { CustomerId = 1, ProductName = "Bánh Mỳ", Price = 10000, Quantity = 1 });
            context.Orders.Add(new Order { CustomerId = 2, ProductName = "Mỳ tôm", Price = 5000, Quantity = 2 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
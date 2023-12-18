using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication.Models
{
    public partial class ShopDataContext : DbContext
    {
        public ShopDataContext()
            : base("name=ShopDataContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

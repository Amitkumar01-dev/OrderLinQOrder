using Microsoft.EntityFrameworkCore;

namespace OrderLinQOrder.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>  options):base(options)
        {
            
        }
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Customer>Customers => Set<Customer>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    }
}

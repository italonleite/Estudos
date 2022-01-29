using Microsoft.EntityFrameworkCore;
using UnitOfShop.Models;

namespace UnitOfShop.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D4JN8G8;Database=UnitShop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

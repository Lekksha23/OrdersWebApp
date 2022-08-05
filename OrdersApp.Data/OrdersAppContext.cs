using Microsoft.EntityFrameworkCore;
using OrdersApp.Data.Entities;

namespace OrdersApp.Data
{
    public class OrdersAppContext : DbContext
    {
        public OrdersAppContext(DbContextOptions<OrdersAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Order> Orders { get; set; }
    }
}

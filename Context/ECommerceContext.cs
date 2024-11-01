using ecommerce_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_Project.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options)
       : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

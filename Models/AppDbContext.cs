using Microsoft.EntityFrameworkCore;

namespace Medicine.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cart> carts { get; set; }  
        public DbSet<Order> orders { get; set; }

        public DbSet<Medicines> medicines { get; set; }  

        public DbSet<OrderItems> ordersItems { get; set; }

        public DbSet<Users> users { get; set; }
    }
}

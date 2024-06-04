using Microsoft.EntityFrameworkCore;
using MVCExo.Models;



namespace MVCExo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        
    }
}

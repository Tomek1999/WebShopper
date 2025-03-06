using Microsoft.EntityFrameworkCore;
using WebShopper.Models;

namespace WebShopper.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { 
        
        }

        public DbSet<Product> Products { get; set; }

    }
}

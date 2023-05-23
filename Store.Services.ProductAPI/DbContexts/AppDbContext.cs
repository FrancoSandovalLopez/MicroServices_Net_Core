using Microsoft.EntityFrameworkCore;
using Store.Services.ProductAPI.Models;

namespace Store.Services.ProductAPI.DbContexts
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}

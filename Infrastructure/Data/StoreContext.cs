
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        // we need to tell the context that we want to map the StoreItems table
        public DbSet<Product> Products { get; set; }
    }
}
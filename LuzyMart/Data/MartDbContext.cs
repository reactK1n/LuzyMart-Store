using LuzyMart.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LuzyMart.Data
{
    public class MartDbContext: DbContext
    {
        public MartDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product>  Products { get; set; }

        public DbSet<Image> Images { get; set; }
    }
}

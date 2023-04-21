using Microsoft.EntityFrameworkCore;
using Test.Data.Seeds;
using Test.Models;

namespace Test.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(p => p.Id).UseSerialColumn();
            SeedProduct.Seed(builder);
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}

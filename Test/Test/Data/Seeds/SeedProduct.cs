using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data.Seeds
{
    public static class SeedProduct
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Product 1", Description = "Description of product 1", Price = 10000 },
                new Product() { Id = 2, Name = "Product 2", Description = "Description of product 2", Price = 15000 },
                new Product() { Id = 3, Name = "Product 3", Description = "Description of product 3", Price = 22000 }
            );
        }
    }
}

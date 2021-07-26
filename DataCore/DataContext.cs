using Microsoft.EntityFrameworkCore;
using Core.Models;
using System;

namespace DataCore
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductCost = 20,
                    ProductDescription = "Fooking Expensive",
                    ProductName = "Jaguar",
                },
                new Product { Id = 2, ProductCost = 40, ProductName = "BENZ", ProductDescription = "I don't think you can afford it" }
                );
        }
    }
}

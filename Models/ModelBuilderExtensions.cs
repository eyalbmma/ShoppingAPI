using Microsoft.EntityFrameworkCore;
using ShoppingAPI.Models;

namespace ShoppingAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "מוצרי חשמל" },
                new Category { Id = 2, Name = "ספרים" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "טלפון", Price = 1999, CategoryId = 1 },
                new Product { Id = 2, Name = "מכונת כביסה", Price = 3500, CategoryId = 1 },
                new Product { Id = 3, Name = "ספר ילדים", Price = 49, CategoryId = 2 }
            );
        }
    }
}

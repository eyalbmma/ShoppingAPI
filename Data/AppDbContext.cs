using Microsoft.EntityFrameworkCore;
using ShoppingAPI.Models;
using System.Collections.Generic;

namespace ShoppingAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed(); // ⬅️ מוסיף את הנתונים הראשוניים
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}

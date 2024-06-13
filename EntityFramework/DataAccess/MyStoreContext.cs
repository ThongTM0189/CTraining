using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityFramework.DataAccess;

public partial class MyStoreContext : DbContext
{
    IConfiguration configuration;
    public MyStoreContext()
    {
    }

    public MyStoreContext(DbContextOptions<MyStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory) 
               .AddJsonFile("appsettings.json")
               .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("defaultConnect"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_categoryId");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

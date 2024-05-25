using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class StoreContext : DbContext
    {
        public StoreContext()
        {
        }

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=ADMIN-PC;UID=sa;PWD=123456;Database=MyStore;Encrypt=True;TrustServerCertificate=True");
    }
}

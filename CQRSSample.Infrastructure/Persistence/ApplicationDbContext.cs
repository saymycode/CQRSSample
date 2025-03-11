using CQRSSample.Application.Interfaces;
using CQRSSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Burada entity yapılandırmaları yapılabilir
            modelBuilder.Entity<Product>().Property(p => p.ProductCode).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(p => p.Consumption).HasColumnType("decimal(18,2)");

            // // Seed data
            // modelBuilder.Entity<Product>().HasData(
            //     new Product
            //     {
            //         Id = 1,
            //         Name = "Ürün 1",
            //         Description = "Ürün 1 açıklaması",
            //         Price = 100.50m,
            //         StockQuantity = 10,
            //         CreatedAt =new DateTime(2000, 2, 1, 0, 0, 0), // SABİT TARİH
            //     },
            //     new Product
            //     {
            //         Id = 2,
            //         Name = "Ürün 2",
            //         Description = "Ürün 2 açıklaması",
            //         Price = 200.75m,
            //         StockQuantity = 5,
            //         CreatedAt = new DateTime(2000, 1, 1, 0, 0, 0), // SABİT TARİH
            //     }
            // );
        }
    }
}

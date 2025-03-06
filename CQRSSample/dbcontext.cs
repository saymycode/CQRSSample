// filepath: /d:/Bitbucket/CQRSSample/CQRSSample/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using CQRSSample.Models;

namespace CQRSSample
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configuration
        }
    }
}
using Retro_Rentals.Models;
using Microsoft.EntityFrameworkCore;

namespace Retro_Rentals.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Membership>().ToTable("Membership");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}

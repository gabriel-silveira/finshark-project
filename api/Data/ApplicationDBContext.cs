using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using api.Models;
using api.Seeders;
using Microsoft.AspNetCore.Identity;

namespace api.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            var roles = IdentityRoleSeederData.GetData();
            foreach (var role in roles)
            {
                modelBuilder.Entity<IdentityRole>().HasData(role);
            }

            var stocks = StockSeedersData.GetData();
            foreach (var stock in stocks)
            {
                modelBuilder.Entity<Stock>().HasData(stock);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using api.Models;
using api.Seeders;
using Microsoft.AspNetCore.Identity;

namespace api.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            CreateRoles(modelBuilder);
            
            CreateAdminUser(modelBuilder);

            modelBuilder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

            modelBuilder.Entity<Portfolio>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.AppUserId);

            modelBuilder.Entity<Portfolio>()
                .HasOne(u => u.Stock)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.StockId);

            var stocks = StockSeedersData.GetData();
            foreach (var stock in stocks)
            {
                modelBuilder.Entity<Stock>().HasData(stock);
            }
        }

        private static void CreateRoles(ModelBuilder modelBuilder)
        {
            var roles = IdentityRoleSeederData.GetData();
            foreach (var role in roles)
            {
                modelBuilder.Entity<IdentityRole>().HasData(role);
            }
        }

        private static void CreateAdminUser(ModelBuilder modelBuilder)
        {
            // var hasherPassword = new PasswordHasher<AppUser>().HashPassword(null, "Kx03dbj49c1!");
            var hasherPassword = "AQAAAAIAAYagAAAAED3Hup7iBlNlErNbFzFPNx/C19h+RFlOL5IPka7CZ8IhZ4FCY+NWKDIZlkTl+jVQ+w==";

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@finshark.com",
                    NormalizedEmail = "ADMIN@FINSHARK.COM",
                    PasswordHash = hasherPassword, // Kx03dbj49c1!
                    SecurityStamp = "MMRSHQWTAIMEP3J4NADMHRMAXKAPCF6K",
                    ConcurrencyStamp = "57e949a6-ef8e-405f-b748-c28672aa43d6",
                    LockoutEnabled = true
                });

            AddRoleToAdminUser(modelBuilder);
        }

        private static void AddRoleToAdminUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "39ee54d4-068b-4643-9e80-0f26bb65a70a",
                    UserId = "68060241-8072-41c9-bef4-ab60b3f4a857"
                });
        }
    }
}

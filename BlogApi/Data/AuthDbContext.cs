using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "1b395eb1-906d-4c8b-b099-80a274ee6213";
            var writerRoleId = "45adfb39-cd57-49f5-8dfa-07ea0a221b1a";

            // Reader[public] & Writer[admin]
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                    ConcurrencyStamp = readerRoleId
                },
                 new IdentityRole()
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                    ConcurrencyStamp = writerRoleId
                }
            };

            // Seed roles to database
            builder.Entity<IdentityRole>().HasData(roles);

            // Create Admin
            var adminUserId = "a714821e-2372-4f35-a5d2-8639f28d42f5";

            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "Admin User",
                Email = "admin@email.com",
                NormalizedEmail = "admin@email.com".ToUpper(),
                NormalizedUserName = "Admin User".ToUpper()
            };
            // Generate admin password
            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin987!");
            // Seed 
            builder.Entity<IdentityUser>().HasData(admin);

            // Admin Roles of reader & writer
            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId
                }
            };
            // Seed admin roles
            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);


        }
    }
}
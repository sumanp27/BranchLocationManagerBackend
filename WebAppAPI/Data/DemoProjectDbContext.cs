using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppAPI.Data.configurations;

namespace WebAppAPI.Data
{
    public class DemoProjectDbContext:IdentityDbContext<ApiUser>
    {
        public DemoProjectDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        }
    }

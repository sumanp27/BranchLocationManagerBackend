using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebAppAPI.Models.Branch;

namespace WebAppAPI.Data
{
    public class DemoProjectDbContext:IdentityDbContext<ApiUser>
    {
        public DemoProjectDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public  virtual DbSet<BranchDto> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BranchMapping());





        }

       
    }
    }

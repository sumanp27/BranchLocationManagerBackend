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
            //modelBuilder.Entity<Branch>(builder =>
            //{
            //    // Date is a DateOnly property and date on database
            //    builder.Property(x => x.OPENED_DT)
            //        .HasConversion<DateOnlyConverter>();


            modelBuilder.ApplyConfiguration(new BranchMapping());





        }

       
    }
    }

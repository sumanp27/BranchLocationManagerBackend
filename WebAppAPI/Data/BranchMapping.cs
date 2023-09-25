using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Graph.Models;
using System.Reflection.Emit;
using WebAppAPI.Models.Branch;

namespace WebAppAPI.Data
{
    public class BranchMapping : IEntityTypeConfiguration<BranchDto>
    {
        public void Configure(EntityTypeBuilder<BranchDto> builder)
        {
            builder.HasKey(t => t.BuCode5);

            builder.Property(e => e.BuCode5).HasColumnName("BU_CODE5");
            builder.ToTable("Branches");
            builder.Property(e => e.OpenedDt)
                    .HasConversion<DateOnlyConverter>()
                    .HasColumnName("OPENED_DT");
               
                
                builder.Property(e => e.Address).HasColumnName("ADDRESS");
                builder.Property(e => e.City).HasColumnName("CITY");
                builder.Property(e => e.StateName).HasColumnName("STATE_NAME");
                builder.Property(e => e.CountryName).HasColumnName("COUNTRY_NAME");
                builder.Property(e => e.Currency).HasColumnName("CURRENCY");
                builder.Property(e => e.Phone).HasColumnName("PHONE");
                builder.Property(e => e.BusinessHours).HasColumnName("BUSINESS_HOURS");
                builder.Property(e => e.Latitude).HasColumnName("LATITUDE");
                builder.Property(e => e.Longitude).HasColumnName("LONGITUDE");
                builder.Property(e => e.Status).HasColumnName("STATUS");


        }
    }
}

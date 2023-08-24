using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace SchoolManager.Models.EntitiesConfiguration
{
    public class ProvinceEntityConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasMany(p => p.Address)
                .WithOne(a => a.Province)
                .HasForeignKey(a => a.ProvinceId);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class LookupEntityMap : IEntityTypeConfiguration<LookupEntity>
    {
        public void Configure(EntityTypeBuilder<LookupEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.LookupGroup)
               .IsRequired()
                .HasMaxLength(30);

            builder.Property(w => w.LookupName)
               .IsRequired()
                .HasMaxLength(40);

            builder.Property(w => w.LookupCode)
               .IsRequired()
                .HasMaxLength(30);

            builder.Property(w => w.LookupValue)
               .IsRequired()
                .HasMaxLength(50);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();


            builder.ToTable("tbl_Lookup");
        }
    }
}

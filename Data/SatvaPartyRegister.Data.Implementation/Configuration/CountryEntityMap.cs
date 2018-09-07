using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class CountryEntityMap : IEntityTypeConfiguration<CountryEntity>
    {
        public void Configure(EntityTypeBuilder<CountryEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.Code)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.Property(w => w.Name)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.Property(w => w.ShortCode)
                  .HasMaxLength(10);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.ToTable("tbl_Country");
        }
    }
}

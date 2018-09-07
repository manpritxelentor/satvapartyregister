using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class StateEntityMap : IEntityTypeConfiguration<StateEntity>
    {
        public void Configure(EntityTypeBuilder<StateEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.Code)
                     .IsRequired()
                     .HasMaxLength(50);

            builder.Property(w => w.StateName)
                     .IsRequired()
                     .HasMaxLength(50);

            builder.Property(w => w.ShortCode)
                     .HasMaxLength(10);

            builder.Property(w => w.StateCode)
                     .IsRequired()
                     .HasMaxLength(4);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.HasOne(w => w.Country)
                .WithMany(w => w.States)
                .HasForeignKey(w => w.CountryId);

            builder.ToTable("tbl_State");
        }
    }
}

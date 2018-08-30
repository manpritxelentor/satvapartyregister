using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class AccountantAdvocateEntityMap : IEntityTypeConfiguration<AccountantAdvocateEntity>
    {
        public void Configure(EntityTypeBuilder<AccountantAdvocateEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(w => w.MobileNumber)
                .HasMaxLength(12);

            builder.Property(w => w.EmailAddress)
                .HasMaxLength(50);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.ToTable("tbl_AccountantAdvocate");
        }
    }
}

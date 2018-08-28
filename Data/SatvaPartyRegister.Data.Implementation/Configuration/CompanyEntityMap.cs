using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class CompanyEntityMap : IEntityTypeConfiguration<CompanyEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.ToTable("tbl_Company");
        }
    }
}

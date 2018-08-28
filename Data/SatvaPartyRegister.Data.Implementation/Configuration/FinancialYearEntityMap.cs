using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class FinancialYearEntityMap : IEntityTypeConfiguration<FinancialYearEntity>
    {
        public void Configure(EntityTypeBuilder<FinancialYearEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.ToTable("tbl_FinancialYear");
        }
    }
}

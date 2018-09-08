using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
   public class ITRegisterEntityMap : IEntityTypeConfiguration<ITRegisterEntity>
    {
        public void Configure(EntityTypeBuilder<ITRegisterEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.HasOne(w => w.Customer)
            .WithMany(w => w.ITRegisters)
            .HasForeignKey(w => w.CustomerId);

            builder.HasOne(w => w.FinancialYear)
            .WithMany(w => w.ITRegisters)
            .HasForeignKey(w => w.FinYearId);

            builder.HasOne(w => w.ITReturnStatus)
            .WithMany(w => w.ITRegisters)
            .HasForeignKey(w => w.ITReturnStatusId);

            builder.HasOne(w => w.AuditStatus)
            .WithMany(w => w.ITRegisters1)
            .HasForeignKey(w => w.AuditStatusId);

            builder.ToTable("tbl_ITRegister");
        }
    }
}

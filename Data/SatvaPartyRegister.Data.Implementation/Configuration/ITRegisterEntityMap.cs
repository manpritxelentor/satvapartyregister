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

            builder.ToTable("tbl_ITRegister");
        }
    }
}

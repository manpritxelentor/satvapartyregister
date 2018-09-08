using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SatvaPartyRegister.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Data.Implementation.Configuration
{
    public class CustomerEntityMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(w => w.PrimaryContactName)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(w => w.FirmName)
                  .HasMaxLength(100);

            builder.Property(w => w.ReffName)
                  .HasMaxLength(100);

            builder.Property(w => w.AddressLine1)
                  .IsRequired();

            builder.Property(w => w.City)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(w => w.MobileNumber)
                 .HasMaxLength(12);

            builder.Property(w => w.EmailAddress)
                 .HasMaxLength(30);

            builder.Property(w => w.AdharNumber)
                .IsRequired()
                 .HasMaxLength(12);

            builder.Property(w => w.PanNumber)
                .IsRequired()
                 .HasMaxLength(10);

            builder.Property(w => w.ITFileNumber)
                 .HasMaxLength(10);

            builder.Property(w => w.ITUserId)
                 .HasMaxLength(50);

            builder.Property(w => w.ITPassword)
                .HasMaxLength(30);

            builder.Property(w => w.GSTNumber)
                .HasMaxLength(12);

             builder.Property(w => w.GSTFileNumber)
                 .HasMaxLength(10);

            builder.Property(w => w.GSTUserId)
                .HasMaxLength(50);

            builder.Property(w => w.GSTPassword)
                .HasMaxLength(30);

            builder.Property(w => w.EwayBillId)
                .HasMaxLength(50);

            builder.Property(w => w.EwayPassword)
                .HasMaxLength(30);

            builder.Property(w => w.VATId)
                .HasMaxLength(50);

            builder.Property(w => w.VATPassword)
                .HasMaxLength(30);

            builder.Property(w => w.RowVersion)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.HasOne(w => w.CustomerType)
               .WithMany(w => w.Customers)
               .HasForeignKey(w => w.CustomerTypeId);

            builder.HasOne(w => w.ReturnInterval)
               .WithMany(w => w.Customers1)
               .HasForeignKey(w => w.ReturnIntervalId);

            builder.HasOne(w => w.State)
               .WithMany(w => w.Customers)
               .HasForeignKey(w => w.StateId);

            builder.HasOne(w => w.Country)
               .WithMany(w => w.Customers)
               .HasForeignKey(w => w.CountryId);

            builder.HasOne(w => w.Accountant)
               .WithMany(w => w.Customers)
               .HasForeignKey(w => w.AccountantId);

            builder.HasOne(w => w.Advocate)
               .WithMany(w => w.Customers1)
               .HasForeignKey(w => w.AdvocateId);

            builder.ToTable("tbl_Customers");
        }
    }
}

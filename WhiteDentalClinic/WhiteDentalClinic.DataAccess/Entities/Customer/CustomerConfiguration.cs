﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteDentalClinic.DataAccess.Entities.Customer
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName)
                .IsRequired();
            builder.Property(c => c.LastName)
                .IsRequired();
            builder.Property(c => c.Age)
                .IsRequired()
                .HasMaxLength(120);
            builder.Property(c => c.Email)
                .IsRequired();
        }
    }
}
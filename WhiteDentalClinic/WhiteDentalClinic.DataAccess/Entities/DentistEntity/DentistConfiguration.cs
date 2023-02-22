using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.DataAccess.Entities.Customer;

namespace WhiteDentalClinic.DataAccess.Entities.Dentist
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Dentist>
    {
        public void Configure(EntityTypeBuilder<Dentist> builder)
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

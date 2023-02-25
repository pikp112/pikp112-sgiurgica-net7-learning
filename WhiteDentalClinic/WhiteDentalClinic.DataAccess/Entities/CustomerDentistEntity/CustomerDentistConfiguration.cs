using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;
using WhiteDentalClinic.DataAccess.Entities.CustomerDentistEntity;

namespace WhiteDentalClinic.DataAccess.Entities.CommonEntities
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerDentist>
    {
        public void Configure(EntityTypeBuilder<CustomerDentist> builder)
        {
            builder.HasKey(customerDentist => new {customerDentist.CustomerId, customerDentist.DentistId});

            builder.HasOne<Customer>(x => x.Customer)
                .WithMany(x => x.Dentists)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne<Dentist>(x => x.Dentist)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.DentistId);
        }
    }
}

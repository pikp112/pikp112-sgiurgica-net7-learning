using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteDentalClinic.DataAccess.Entities.AppointmentEntity
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Day)
                .IsRequired();
            builder.Property(a => a.StartTime)
                .IsRequired();
            builder.Property(a => a.FinishTime)
                .IsRequired();
        }
    }
}

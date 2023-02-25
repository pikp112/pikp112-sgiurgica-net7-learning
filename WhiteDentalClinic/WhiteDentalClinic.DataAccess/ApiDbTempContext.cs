using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WhiteDentalClinic.DataAccess.Entities.AppointmentEntity;
using WhiteDentalClinic.DataAccess.Entities.CustomerDentistEntity;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;
using WhiteDentalClinic.DataAccess.Entities.MedicalServiceEntity;

namespace WhiteDentalClinic.DataAccess
{
    public class ApiDbTempContext : DbContext
    {
        public ApiDbTempContext(DbContextOptions options) : base(options) { }
        /*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseInMemoryDatabase(databaseName: "CustomerDb");
                }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //base.OnModelCreating(modelBuilder); need to be deleted?
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<CustomerDentist> CustomerDentists { get; set; }
        public DbSet<MedicalService> MedicalServices { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
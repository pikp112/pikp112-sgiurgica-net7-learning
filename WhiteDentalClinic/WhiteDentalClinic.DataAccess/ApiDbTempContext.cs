using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WhiteDentalClinic.DataAccess.Entities.CommonEntities;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;

namespace WhiteDentalClinic.DataAccess
{
    public class ApiDbTempContext : DbContext
    {
        public ApiDbTempContext(DbContextOptions options) : base(options)  { }
/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "CustomerDb");
        }
*/        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<CustomerDentist> CustomerDentists { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WhiteDentalClinic.DataAccess.Entities.Custoner;
using WhiteDentalClinic.DataAccess.Entities.Dentist;

namespace WhiteDentalClinic.DataAccess
{
    public class ApiDbTempContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "CustomerDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
    }
}

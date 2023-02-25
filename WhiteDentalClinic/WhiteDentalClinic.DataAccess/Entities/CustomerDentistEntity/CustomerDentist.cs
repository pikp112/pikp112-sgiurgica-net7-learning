using WhiteDentalClinic.DataAccess.Entities.DentistEntity;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;

namespace WhiteDentalClinic.DataAccess.Entities.CustomerDentistEntity
{
    public class CustomerDentist
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid DentistId { get; set; }
        public Dentist Dentist { get; set; }
    }
}

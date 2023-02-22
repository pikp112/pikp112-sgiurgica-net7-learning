using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;

namespace WhiteDentalClinic.DataAccess.Entities.Customer
{
    public class Customer : BaseCustomer
    {
        public Guid Id { get; set; }
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [MinLength(2)]
        public int Age { get; set; }
        public string Email { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.Customer
{
    public class CreateCustomerRequestModel
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
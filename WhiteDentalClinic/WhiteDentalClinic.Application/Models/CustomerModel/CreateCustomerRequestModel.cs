using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.Customer
{
    public class CreateCustomerRequestModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
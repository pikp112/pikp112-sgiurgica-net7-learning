using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.Dentist
{
    public class CreateDentistRequestModel
    {
        public Guid Id { get; set; }
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

    }
}
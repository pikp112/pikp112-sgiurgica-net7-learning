using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;

namespace WhiteDentalClinic.DataAccess.Entities.Dentist
{
    public class Dentist : BaseDentist
    {
        public Guid Id { get; set; }
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [Range(16, 120)]
        public int Age { get; set; }
        public string Email { get; set; }
    }
}

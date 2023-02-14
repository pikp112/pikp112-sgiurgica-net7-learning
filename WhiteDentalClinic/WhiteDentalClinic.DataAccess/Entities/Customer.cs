using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.DataAccess.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [Range(16, 120)]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }

        [EnumDataType(typeof(Role))]
        public Role Role { get; } = Role.Customer;


    }
}

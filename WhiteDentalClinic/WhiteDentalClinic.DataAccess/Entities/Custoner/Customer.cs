using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.DataAccess.Entities.Custoner
{
    public class Customer
    {
        public Guid Id { get; set; }
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [Range(16, 120)]
        public int Age { get; set; }
        public string Email { get; set; }

        [EnumDataType(typeof(Role))]
        public Role Role { get; } = Role.Customer;


    }
}

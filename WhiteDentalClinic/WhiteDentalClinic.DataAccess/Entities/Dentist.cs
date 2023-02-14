using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteDentalClinic.DataAccess.Entities
{
    public class Dentist
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }

        [EnumDataType(typeof(Role))]
        public Role Role { get; } = Role.Dentist;

    }
}

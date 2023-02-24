using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteDentalClinic.DataAccess.Entities.DentistEntity
{
    public class BaseDentist
    {
        [EnumDataType(typeof(Role))]
        public Role Role { get; } = Role.Dentist;

    }
}

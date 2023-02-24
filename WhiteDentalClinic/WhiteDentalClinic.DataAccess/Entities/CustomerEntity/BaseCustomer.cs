using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.DataAccess.Entities.CustomerEntity
{
    public class BaseCustomer
    {
        [EnumDataType(typeof(Role))]
        public Role Role { get; } = Role.Customer;

    }
}

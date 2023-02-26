using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.DataAccess.Entities.CommonEntities;
using WhiteDentalClinic.DataAccess.Entities.CustomerDentistEntity;
using WhiteDentalClinic.DataAccess.Entities.MedicalServiceEntity;

namespace WhiteDentalClinic.DataAccess.Entities.DentistEntity
{
    public class Dentist : BaseEntity
    {
        public Dentist()
        {
            CreatedAt = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public override Role Role => Role.Dentist;
        public DateTime CreatedAt { get; set; }
        public List<CustomerDentist> Customers { get; set; }
        public Guid MedicalServiceId { get; set; }
        public MedicalService MedicalService { get; set; }
    }
}

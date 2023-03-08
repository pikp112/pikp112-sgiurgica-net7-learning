using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;

namespace WhiteDentalClinic.DataAccess.Entities.AppointmentEntity
{
    public class Appointment
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime FinishTime { get; set; }
        public TimeSpan Duration => FinishTime - StartTime;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid DentistId { get; set; }
        public Dentist Dentist { get; set; }
    }
}
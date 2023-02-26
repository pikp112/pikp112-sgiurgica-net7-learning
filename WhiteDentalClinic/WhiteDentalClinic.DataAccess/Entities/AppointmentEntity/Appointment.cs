using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;

namespace WhiteDentalClinic.DataAccess.Entities.AppointmentEntity
{
    public class Appointment
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString ="{0:hh:mm}")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime FinishTime { get; set; }
        public TimeSpan Duration => FinishTime - StartTime;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
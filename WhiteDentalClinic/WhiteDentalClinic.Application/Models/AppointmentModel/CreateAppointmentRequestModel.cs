using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.AppointmentModel
{
    public class CreateAppointmentRequestModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime StartTime { get; set; }
        public Guid CustomerId { get; set; }
    }
}
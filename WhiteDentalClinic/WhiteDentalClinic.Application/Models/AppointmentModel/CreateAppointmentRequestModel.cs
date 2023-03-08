using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.AppointmentModel
{
    public class CreateAppointmentRequestModel
    {
        public Guid Id = Guid.NewGuid();

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime FinishTime { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DentistId { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.AppointmentModel
{
    public class AppointmentResponseModel
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime FinishTime { get; set; }

    }
}
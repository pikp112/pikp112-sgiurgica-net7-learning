using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.AppointmentModel
{
    public class AppointmentResponseModel
    {
        public Guid Id { get; set; }
        public DateTime dateTime { get; set; }
    }
}
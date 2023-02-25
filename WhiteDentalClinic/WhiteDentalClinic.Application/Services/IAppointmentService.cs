using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.Application.Models.AppointmentModel;
using WhiteDentalClinic.Application.Models.Dentist;

namespace WhiteDentalClinic.Application.Services
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentResponseModel> GetAllAppointmentsByCustomer(Guid customerRequestId);
        AppointmentResponseModel GetAppointmentById(Guid appointmentId);
        AppointmentResponseModel CreateAppointment(CreateAppointmentRequestModel requestAppointmentModel);
        AppointmentResponseModel DeleteAppointment(Guid appointmentId);

    }
}

using AutoMapper;
using WhiteDentalClinic.Application.Models.AppointmentModel;
using WhiteDentalClinic.Application.Models.Dentist;
using WhiteDentalClinic.Application.Services.Interfaces;
using WhiteDentalClinic.DataAccess.Entities.AppointmentEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;
using WhiteDentalClinic.DataAccess.Repositories.AppointmentRepository;

namespace WhiteDentalClinic.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;
        public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _appointmentRepository= appointmentRepository;
            _mapper= mapper;
        }
        public IEnumerable<AppointmentResponseModel> GetAllAppointmentsByCustomer(Guid customerRequestId)
        {
            var selectedAppointmentByCustomerId = _appointmentRepository.GetAll().Where(app => app.CustomerId== customerRequestId);
            return _mapper.Map<IEnumerable<AppointmentResponseModel>>(selectedAppointmentByCustomerId);
        }
        public AppointmentResponseModel GetAppointmentById(Guid appointmentId)
        {
            var selectedAppointmentById = _appointmentRepository.GetAll().FirstOrDefault(app => app.Id == appointmentId);
            return _mapper.Map<AppointmentResponseModel>(selectedAppointmentById);
        }

        public AppointmentResponseModel CreateAppointment(CreateAppointmentRequestModel requestAppointmentModel)
        {
            var newAppointment = _mapper.Map<Appointment>(requestAppointmentModel);
            newAppointment.Id = Guid.NewGuid();

            this._appointmentRepository.AddEntity(newAppointment);

            return _mapper.Map<AppointmentResponseModel>(newAppointment);
        }

        public AppointmentResponseModel DeleteAppointment(Guid appointmentId)
        {
            var selectedAppointmentById = _appointmentRepository.GetAll().FirstOrDefault(app => app.Id == appointmentId);

            _appointmentRepository.DeleteEntity(selectedAppointmentById);

            return _mapper.Map<AppointmentResponseModel>(selectedAppointmentById);
        }
    }
}

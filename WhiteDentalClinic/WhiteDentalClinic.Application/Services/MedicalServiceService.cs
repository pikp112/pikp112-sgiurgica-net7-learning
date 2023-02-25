using AutoMapper;
using WhiteDentalClinic.Application.Exceptions;
using WhiteDentalClinic.Application.Models.Dentist;
using WhiteDentalClinic.Application.Models.MedicalServiceModel;
using WhiteDentalClinic.DataAccess.Entities.MedicalServiceEntity;
using WhiteDentalClinic.DataAccess.Repositories.MedicalServiceRepository;

namespace WhiteDentalClinic.Application.Services
{
    public class MedicalServiceService : IMedicalServiceService
    {
        private readonly IMapper _mapper;
        private readonly IMedicalServiceRepository _medicalServiceRepository;
        public MedicalServiceService(IMedicalServiceRepository medicalServiceRepository, IMapper mapper) 
        {
            _medicalServiceRepository= medicalServiceRepository;
            _mapper = mapper;
        }
        public IEnumerable<ResponseMedicalServices> GetAllMedicalServices()
        {
            var listMedicalServices = _medicalServiceRepository.GetAll();
            return _mapper.Map<IEnumerable<ResponseMedicalServices>>(listMedicalServices);
        }

        public ResponseMedicalServices CreateAMedicalService(CreateMedicalService requestMedicalServiceModel)
        {
            var newMedicalService = _mapper.Map<MedicalService>(requestMedicalServiceModel);
            newMedicalService.Id = Guid.NewGuid();
            _medicalServiceRepository.AddEntity(newMedicalService);
            return _mapper.Map<ResponseMedicalServices>(newMedicalService);
        }

        public ResponseMedicalServices DeleteMedicalService(Guid id)
        {
            var medicaServiceById = _medicalServiceRepository.GetAll().FirstOrDefault(ms => ms.Id == id);
            _medicalServiceRepository.DeleteEntity(medicaServiceById);
            return _mapper.Map<ResponseMedicalServices>(medicaServiceById);

        }

        public UpdateResponseMedicalService UpdateMedicalService(Guid id, UpdateRequestMedicalService updateMedicalServiceModel)
        {
            var selectedMedicalService = _medicalServiceRepository.GetAll().FirstOrDefault(x => x.Id == id);

            var medicalServiceId = Guid.Parse(id.ToString()); // need to implement claim service - httcpcontext

            if (medicalServiceId != selectedMedicalService.Id)
            {
                throw new BadRequestException("You can update only your email.");
            }

            selectedMedicalService.Price = updateMedicalServiceModel.Price;

            return new UpdateResponseMedicalService
            {
                Id = _medicalServiceRepository.UpdateEntity(selectedMedicalService).Id
            };

        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.Application.Exceptions;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.Application.Models.Dentist;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;
using WhiteDentalClinic.DataAccess.Repositories.CustomerRepository;
using WhiteDentalClinic.DataAccess.Repositories.DentistRepository;
using WhiteDentalClinic.Shared.Services;
using UpdateDentistResponseModel = WhiteDentalClinic.Application.Models.Dentist.UpdateDentistResponseModel;

namespace WhiteDentalClinic.Application.Services
{
    public class DentistService : IDentistService
    {
        private readonly IClaimService _claimService;
        private readonly IMapper _mapper;
        private readonly IDentistRepository _dentistRepository;
        public DentistService(IDentistRepository customerRepository, IMapper mapper, IClaimService claimService)
        {
            _dentistRepository = customerRepository;
            _mapper = mapper;
            _claimService = claimService;
        }
        public IEnumerable<DentistResponseModel> GetAllDentists()
        {
            var responseModelListDentists = _dentistRepository.GetAll();

            return _mapper.Map<IEnumerable<DentistResponseModel>>(responseModelListDentists);

        }
        public DentistResponseModel GetDentistById(Guid id)
        {
            var dentistbyId = _dentistRepository.GetAll().FirstOrDefault(x => x.Id == id);

            return _mapper.Map<DentistResponseModel>(dentistbyId);
        }

        public DentistResponseModel CreateDentist(CreateDentistRequestModel requestDentistModel)
        {
            var newDentist = _mapper.Map<Dentist>(requestDentistModel);

            this._dentistRepository.AddEntity(newDentist);

            return _mapper.Map<DentistResponseModel>(newDentist);
        }

        public DentistResponseModel DeleteDentist(Guid id)
        {
            var dentistbyId = _dentistRepository.GetAll().FirstOrDefault(x => x.Id == id);

            _dentistRepository.DeleteEntity(dentistbyId);

            return _mapper.Map<DentistResponseModel>(dentistbyId);
        }


        public UpdateDentistResponseModel UpdateDentist(Guid id, UpdateDentistRequestModel updateDentistModel)
        {
            var selectedDentist = _dentistRepository.GetAll().FirstOrDefault(x => x.Id == id);

            var userDentistId = _claimService.GetUserId();

            if (userDentistId != selectedDentist.Id.ToString())
            {
                throw new BadRequestException("You can update only your email.");
            }

            selectedDentist.Email = updateDentistModel.Email;  

            return new UpdateDentistResponseModel
            {
                Id = _dentistRepository.UpdateEntity(selectedDentist).Id
            };
        }
    }
}

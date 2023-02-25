﻿using AutoMapper;
using WhiteDentalClinic.Application.Exceptions;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.DataAccess.Entities.CustomerEntity;
using WhiteDentalClinic.DataAccess.Repositories.CustomerRepository;
using WhiteDentalClinic.DataAccess.Repositories.MedicalServiceRepository;
using WhiteDentalClinic.Shared.Services;
using UpdateCustomerResponseModel = WhiteDentalClinic.Application.Models.Customer.UpdateCustomerResponseModel;


namespace WhiteDentalClinic.Application.Services
{
    public class CustomerService : ICustomerService
    {
        //private readonly IClaimService _claimService;
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            //_claimService = claimService;
        }
        //poti face o clasa generica de return
        public IEnumerable<CustomerResponseModel> GetAllCustomers()
        {
            var responseModelListCustomers = _customerRepository.GetAll();

            return _mapper.Map<IEnumerable<CustomerResponseModel>>(responseModelListCustomers);
        }
        public CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel)
        {
            var newCustomer = _mapper.Map<Customer>(requestCustomerModel);

            this._customerRepository.AddEntity(newCustomer);

            return _mapper.Map<CustomerResponseModel>(newCustomer);
        }
        public CustomerResponseModel GetCustomerById(Guid id)
        {
            var customerById = _customerRepository.GetAll().FirstOrDefault(x => x.Id == id);

            return _mapper.Map<CustomerResponseModel>(customerById);
        }
        public UpdateCustomerResponseModel UpdateCustomer(Guid id, UpdateCustomerRequestModel updateCustomerModel)
        {
            var selectedCustomer = _customerRepository.GetAll().FirstOrDefault(x => x.Id == id);

            var userCustomerId = Guid.Parse(id.ToString()); // need to implement claim service - httcpcontext

            if (userCustomerId != selectedCustomer.Id)
            {
                throw new BadRequestException("You can update only your email.");
            }

            selectedCustomer.Email = updateCustomerModel.Email;   // need to catch Exception

            return new UpdateCustomerResponseModel
            {
                Id = _customerRepository.UpdateEntity(selectedCustomer).Id
            };
        }
        public CustomerResponseModel DeleteCustomer(Guid id)
        {
            var customerById = _customerRepository.GetAll().FirstOrDefault(x => x.Id == id);

            _customerRepository.DeleteEntity(customerById);

            return _mapper.Map<CustomerResponseModel>(customerById);
        }
    }
}

using AutoMapper;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.DataAccess.Entities.Customer;
using WhiteDentalClinic.DataAccess.Repositories;

namespace WhiteDentalClinic.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
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
        public CustomerResponseModel DeleteCustomer(Guid id)
        {
            var customerById = _customerRepository.GetAll().FirstOrDefault(x => x.Id == id);

            _customerRepository.DeleteEntity(customerById);

            return _mapper.Map<CustomerResponseModel>(customerById);
        }

    }
}

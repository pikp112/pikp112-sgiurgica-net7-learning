using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.DataAccess.Entities;
using WhiteDentalClinic.DataAccess.Entities.Custoner;
using WhiteDentalClinic.DataAccess.Repositories;

namespace WhiteDentalClinic.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        //poti face o clasa generica de return
        public List<CustomerResponseModel> GetAllCustomers()
        {
            var responseModelListCustomers = _customerRepository.GetAll().Select(x => new CustomerResponseModel
            {
                Id= x.Id,
                FirstName= x.FirstName,
                LastName= x.LastName, 
                Age= x.Age,
                Email = x.Email
            }).ToList();

            return responseModelListCustomers;
        }
        public CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel)
        {
            var newCustomer = new Customer
            {
                Id= Guid.NewGuid(),
                FirstName = requestCustomerModel.FirstName,
                LastName = requestCustomerModel.LastName,
                Age = requestCustomerModel.Age,
                Email= requestCustomerModel.Email
            };

            var addCustomer = this._customerRepository.AddEntity(newCustomer);

            return CustomerResponseModel.FromCustomer(newCustomer);
            

        }
        public CustomerResponseModel GetCustomerById(Guid id)
        {
            var customerById = _customerRepository.GetAll().FirstOrDefault(x =>x.Id == id);
            return CustomerResponseModel.FromCustomer(customerById);
        }
        public CustomerResponseModel DeleteCustomer(Guid id)
        {
            var customerById = _customerRepository.GetAll ().FirstOrDefault(x => x.Id == id);

            _customerRepository.DeleteEntity(customerById);

            return CustomerResponseModel.FromCustomer(customerById);
        }

    }
}

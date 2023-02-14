using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.Api.Controllers;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.DataAccess;
using WhiteDentalClinic.DataAccess.Entities;
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
        public List<CustomerResponseModel> GetAllCustomers() => _customerRepository.GetCustomers();
        public CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel) => _customerRepository.CreateCustomer(requestCustomerModel);
        public CustomerResponseModel GetCustomerById(Guid id) => _customerRepository.GetCustomerById(id);


    }
}

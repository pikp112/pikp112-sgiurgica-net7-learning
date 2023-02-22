﻿using WhiteDentalClinic.Application.Models.Customer;

namespace WhiteDentalClinic.Application.Services
{
    public interface ICustomerService
    {
        IEnumerable<CustomerResponseModel> GetAllCustomers();
        CustomerResponseModel GetCustomerById(Guid id);
        CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel);
        CustomerResponseModel DeleteCustomer(Guid id);
    }
}
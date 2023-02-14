using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.Api.Controllers;
using WhiteDentalClinic.Application.Models;

namespace WhiteDentalClinic.Application.Services
{
    public interface ICustomerService
    {
        List<CustomerResponseModel> GetAllCustomers();
        CustomerResponseModel GetCustomerById(Guid id);
        CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel);
    }
}

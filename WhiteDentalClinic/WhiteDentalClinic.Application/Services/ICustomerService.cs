using WhiteDentalClinic.Api.Controllers;
using WhiteDentalClinic.Application.Models;

namespace WhiteDentalClinic.Application.Services
{
    public interface ICustomerService
    {
        List<CustomerResponseModel> GetAllCustomers();
        CustomerResponseModel GetCustomerById(Guid id);
        CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel);
        CustomerResponseModel DeleteCustomer(Guid id);
    }
}

using WhiteDentalClinic.Api.Controllers;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.DataAccess.Entities;

namespace WhiteDentalClinic.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        List<CustomerResponseModel> GetCustomers();
        CustomerResponseModel GetCustomerById(Guid id);
        CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel);
    }
}

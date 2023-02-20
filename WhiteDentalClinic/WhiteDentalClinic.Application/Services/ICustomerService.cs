using WhiteDentalClinic.Application.Models.Customer;

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

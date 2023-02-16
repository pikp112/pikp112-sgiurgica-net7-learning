using WhiteDentalClinic.DataAccess.Entities.Custoner;
using WhiteDentalClinic.DataAccess.Repositories.BaseRepositories;

namespace WhiteDentalClinic.DataAccess.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
       /* List<Customer> GetCustomers();
        Customer CreateCustomer(Customer requestCustomerModel);
        void DeleteCustomer(Customer customer);*/
    }
}
using WhiteDentalClinic.DataAccess.Entities.Customer;

namespace WhiteDentalClinic.DataAccess.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>,ICustomerRepository  
    {
        protected CustomerRepository(ApiDbTempContext context) : base(context)
        { }

       /* public List<Customer> GetCustomers()
        {
            using (var context = new ApiDbTempContext())
            {
                return context.Customers.ToList();
            }
        }
            
        public Customer CreateCustomer(Customer customer)
        {
            using (var context = new ApiDbTempContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();

                return customer;
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            using(var context = new ApiDbTempContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }*/
    }
}


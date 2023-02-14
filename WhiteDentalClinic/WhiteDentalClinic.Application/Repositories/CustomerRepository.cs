using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.Api.Controllers;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.DataAccess.Entities;

namespace WhiteDentalClinic.DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
/*        public CustomerRepository()
        {
            using (var context = new ApiDbTempContext())
            {
                var customers = new List<Customer>
                {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName ="Popescu",
                    LastName ="Mihai",
                    Age= 30,
                    Email = "pm@gmail.com"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName ="Vladimir",
                    LastName ="Ioan",
                    Age= 35,
                    Email = "va@gmail.com"
                }
                };
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }
        }

*/        public List<CustomerResponseModel> GetCustomers()
        {
            using (var context = new ApiDbTempContext())
            {
                var reponseCustomers = context.Customers.ToList().Select(x => new CustomerResponseModel
                {
                    Id= x.Id,
                    FirstName= x.FirstName,
                    LastName= x.LastName,
                    Age= x.Age,
                    Email= x.Email
                }).ToList();

                return reponseCustomers;
            }
        }
        public CustomerResponseModel GetCustomerById(Guid id)
        {
            using (var context = new ApiDbTempContext())
            {
                var customerSelected = context.Customers.FirstOrDefault(x => x.Id == id);

                return CustomerResponseModel.FromCustomer(customerSelected);
            }
        }

        public CustomerResponseModel CreateCustomer(CreateCustomerRequestModel requestCustomerModel)
        {
            using (var context = new ApiDbTempContext())
            {
                var newCustomer = new Customer
                {
                    Id= Guid.NewGuid(),
                    FirstName = requestCustomerModel.FirstName,
                    LastName = requestCustomerModel.LastName,
                    Age = requestCustomerModel.Age,
                    Email= requestCustomerModel.Email
                };

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                return CustomerResponseModel.FromCustomer(newCustomer);
            }
        }
    }
}


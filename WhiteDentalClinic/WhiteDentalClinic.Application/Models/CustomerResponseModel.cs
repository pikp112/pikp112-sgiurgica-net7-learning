using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.DataAccess.Entities;

namespace WhiteDentalClinic.Application.Models
{
    public class CustomerResponseModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public static CustomerResponseModel FromCustomer(Customer model)
        {
            return new CustomerResponseModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Email = model.Email
            };
        }
    }
}
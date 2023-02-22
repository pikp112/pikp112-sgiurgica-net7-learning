
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.DataAccess.Entities.Customer;

namespace WhiteDentalClinic.Application.Models.Customer
{
    public class CustomerResponseModel : BaseResponseModel
    {
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [MinLength(2)]
        public int Age { get; set; }
        public string Email { get; set; }
    }
}


// toate api sa recurneze o clasa generica  iSucceseful(true/false) ori, ori Errors[], Result [], comuna la tot ce returneaza

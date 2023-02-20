using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.Application.Services;
using WhiteDentalClinic.DataAccess.Entities.Dentist;

namespace WhiteDentalClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]  
        public ActionResult<List<Dentist>> GetAllCustomers()
        {
            //poti face o clasa generica de return
            return Ok(_customerService.GetAllCustomers()); // ApiResponseModel<List<Dentist>>
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(Guid id)
        {
            return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.GetCustomerById(id)));
        }

        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerRequestModel requestCustomerModel) 
        {
            try
            {
                return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.CreateCustomer(requestCustomerModel)));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure("You need to insert all required elements.")); 
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(Guid id)
        {
            try
            {
                return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.DeleteCustomer(id)));
            }
            catch(ValidationException ex)
            {
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure("You insert a wrong ID. Please, try again!"));
            }
        }
    }
}

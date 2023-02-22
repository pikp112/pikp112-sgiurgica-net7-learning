using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.Application.Services;

namespace WhiteDentalClinic.Api.Controllers
{
    public class CustomersController : ApiController
    {
        readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]  
        public ActionResult<IEnumerable<CustomerResponseModel>> GetAllCustomers()
        {
            return Ok(ApiGenericsResult<IEnumerable<CustomerResponseModel>>.Success(_customerService.GetAllCustomers()));
        }

        [HttpGet("{id:guid}")]
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
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure(new[] { "You need to insert all required elements." })); 
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
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure(new[] { "You insert a wrong ID. Please, try again!" }));
            }
        }
    }
}

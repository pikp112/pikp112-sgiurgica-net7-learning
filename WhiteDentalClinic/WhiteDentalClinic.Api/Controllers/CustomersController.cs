using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Models.Customer;
using WhiteDentalClinic.Application.Services.Interfaces;

namespace WhiteDentalClinic.Api.Controllers
{
    public class CustomersController : ApiController
    {
        readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //need to check status response
        [HttpGet]  
        public ActionResult<IEnumerable<CustomerResponseModel>> GetAllCustomers()
        {
            return Ok(ApiGenericsResult<IEnumerable<CustomerResponseModel>>.Success(_customerService.GetAllCustomers()));
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCustomerById(Guid id)
        {
            return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.GetCustomerById(id)));
            // to do BadRequest
        }

        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerRequestModel requestCustomerModel) 
        {
            try
            {
                return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.CreateCustomer(requestCustomerModel)));
            }
            catch(Exception ex)
            {
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure(new[] {$"{ex.Message}"})); 
            }
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpdateCustomer(Guid id, UpdateCustomerRequestModel updateCustomerModel)
        {
            try
            {
                return Ok(ApiGenericsResult<UpdateCustomerResponseModel>.Success(_customerService.UpdateCustomer(id, updateCustomerModel)));
            }
            catch(Exception ex)
            {
                return BadRequest(ApiGenericsResult<UpdateCustomerResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(Guid id)
        {
            try
            {
                return Ok(ApiGenericsResult<CustomerResponseModel>.Success(_customerService.DeleteCustomer(id)));
            }
            catch(Exception ex)
            {
                return BadRequest(ApiGenericsResult<CustomerResponseModel>.Failure(new[] { $"{ex.Message}"}));
            }
        }
    }
}

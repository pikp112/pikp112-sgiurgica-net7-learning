using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
            return Ok(_customerService.GetCustomerById(id));
        }

        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerRequestModel requestCustomerModel) 
        {
            try
            {
                return Ok(_customerService.CreateCustomer(requestCustomerModel));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(Guid id)
        {
            try
            {
                return Ok(_customerService.DeleteCustomer(id));
            }
            catch(ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

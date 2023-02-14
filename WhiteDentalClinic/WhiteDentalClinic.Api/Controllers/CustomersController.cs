using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Extensions.Msal;
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.Application.Services;
using WhiteDentalClinic.DataAccess.Entities;
using WhiteDentalClinic.DataAccess.Repositories;

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
            return Ok(_customerService.GetAllCustomers());
        }

        [HttpGet("{id}")]  // /customers/{id}
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
                return BadRequest(ex.Message);   //ex. daca utilizatorul incarca un CSV, arunci exceptie. Asta e o validare! Trebuie in Api Layer
            }
        }


        // GET: CustomersController
        /*        public ActionResult Index()
                {
                    return View();
                }

                // GET: CustomersController/Details/5
                public ActionResult Details(int id)
                {
                    return View();
                }

                // GET: CustomersController/Create
                public ActionResult Create()
                {
                    return View();
                }

                // POST: CustomersController/Create
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Create(IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }

                // GET: CustomersController/Edit/5
                public ActionResult Edit(int id)
                {
                    return View();
                }

                // POST: CustomersController/Edit/5
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Edit(int id, IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }

                // GET: CustomersController/Delete/5
                public ActionResult Delete(int id)
                {
                    return View();
                }

                // POST: CustomersController/Delete/5
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Delete(int id, IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }
        */
    }
}

using Microsoft.AspNetCore.Mvc;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Services;
using WhiteDentalClinic.Application.Models.Dentist;

namespace WhiteDentalClinic.Api.Controllers
{
    public class DentistsController : ApiController
    {
        private readonly IDentistService _dentistService;
        public DentistsController(IDentistService dentistService) 
        {
            _dentistService= dentistService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DentistResponseModel>> GetAllDentists()
        {
            return Ok(ApiGenericsResult<IEnumerable<DentistResponseModel>>.Success(_dentistService.GetAllDentists()));
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetDentistById(Guid id)
        {
            return Ok(ApiGenericsResult<DentistResponseModel>.Success(_dentistService.GetDentistById(id)));
            // to do BadRequest
        }

        [HttpPost]
        public IActionResult CreateDentist(CreateDentistRequestModel requestDentistModel)
        {
            try
            {
                return Ok(ApiGenericsResult<DentistResponseModel>.Success(_dentistService.CreateDentist(requestDentistModel)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<DentistResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateDentist (Guid id, UpdateDentistRequestModel updateDentistModel)
        {
            try
            {
                return Ok(ApiGenericsResult<UpdateDentistResponseModel>.Success(_dentistService.UpdateDentist(id, updateDentistModel)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<UpdateDentistResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }

        [HttpDelete]
        public IActionResult DeleteDentist(Guid id)
        {
            try
            {
                return Ok(ApiGenericsResult<DentistResponseModel>.Success(_dentistService.DeleteDentist(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<DentistResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }
    }
}

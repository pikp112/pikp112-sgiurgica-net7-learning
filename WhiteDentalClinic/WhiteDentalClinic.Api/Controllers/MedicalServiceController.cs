using Microsoft.AspNetCore.Mvc;
using WhiteDentalClinic.Application.Models.Dentist;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Models.MedicalServiceModel;
using WhiteDentalClinic.Application.Services.Interfaces;

namespace WhiteDentalClinic.Api.Controllers
{
    public class MedicalServiceController : ApiController
    {
        private readonly IMedicalServiceService _medicalService;
        public MedicalServiceController(IMedicalServiceService medicalService) 
        {
            _medicalService= medicalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ResponseMedicalServices>> GetAllMedicalServices()
        {
            return Ok(ApiGenericsResult<IEnumerable<ResponseMedicalServices>>.Success(_medicalService.GetAllMedicalServices()));
        }

        [HttpPost]
        public IActionResult CreateAMedicalService(CreateMedicalService requestMedicalServiceModel)
        {
            try
            {
                return Ok(ApiGenericsResult<ResponseMedicalServices>.Success(_medicalService.CreateAMedicalService(requestMedicalServiceModel)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<ResponseMedicalServices>.Failure(new[] { $"{ex.Message}" }));
            }
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateMedicalService(Guid id, UpdateRequestMedicalService updateRequestMedicalServiceModel)
        {
            try
            {
                return Ok(ApiGenericsResult<UpdateResponseMedicalService>.Success(_medicalService.UpdateMedicalService(id, updateRequestMedicalServiceModel)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<UpdateDentistResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }

        [HttpDelete]
        public IActionResult DeleteMedicalService(Guid id)
        {
            try
            {
                return Ok(ApiGenericsResult<ResponseMedicalServices>.Success(_medicalService.DeleteMedicalService(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiGenericsResult<DentistResponseModel>.Failure(new[] { $"{ex.Message}" }));
            }
        }

    }
}

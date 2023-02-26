using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WhiteDentalClinic.Application.Models;
using WhiteDentalClinic.Application.Models.AppointmentModel;
using WhiteDentalClinic.Application.Services.Interfaces;

namespace WhiteDentalClinic.Api.Controllers
{
    public class AppointmentController : ApiController
    {
        readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        //need to check status response
        [HttpGet]
        public ActionResult<IEnumerable<AppointmentResponseModel>> GetAllAppointmentsByCustomer(Guid customerRequestId)
        {
            return Ok(ApiGenericsResult<IEnumerable<AppointmentResponseModel>>.Success(_appointmentService.GetAllAppointmentsByCustomer(customerRequestId)));
            // to do BadRequest
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAppointmentById(Guid id)
        {
            return Ok(ApiGenericsResult<AppointmentResponseModel>.Success(_appointmentService.GetAppointmentById(id)));
            // to do BadRequest
        }

        [HttpPost]
        public IActionResult CreateAppointment(CreateAppointmentRequestModel requestAppointmentModel) 
        {
            try
            {
                return Ok(ApiGenericsResult<AppointmentResponseModel>.Success(_appointmentService.CreateAppointment(requestAppointmentModel)));
            }
            catch(Exception ex)
            {
                return BadRequest(ApiGenericsResult<AppointmentResponseModel>.Failure(new[] {$"{ex.Message}"})); 
            }
        }

        [HttpDelete]
        public IActionResult DeleteAppointment(Guid appointmentId)
        {
            try
            {
                return Ok(ApiGenericsResult<AppointmentResponseModel>.Success(_appointmentService.DeleteAppointment(appointmentId)));
            }
            catch(Exception ex)
            {
                return BadRequest(ApiGenericsResult<AppointmentResponseModel>.Failure(new[] { $"{ex.Message}"}));
            }
        }
    }
}

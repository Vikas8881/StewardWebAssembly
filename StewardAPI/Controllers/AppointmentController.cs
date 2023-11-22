using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Model;
using StewardAPI.Repository.AppointmentRepo;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointment;

        public AppointmentController(IAppointmentRepository appointment)
        {
            _appointment = appointment;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<AppointmentModel>>>> addAppointment(AppointmentModel Appointment)
        {
            var result = await _appointment.CreateAppointment(Appointment);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<AppointmentModel>>>> GetAppointments()
        {

            var result = await _appointment.GetAppointmentHospital();
            return Ok(result);
        }
        [HttpPut/*, Authorize(Roles = "Admin")*/]
        public async Task<ActionResult<ServiceResponse<AppointmentModel>>> UpdateAppointments(AppointmentModel Appointment)
        {
            var result = await _appointment.UpdateAppointment(Appointment);
            return Ok(result);
        }
        [HttpDelete("{Id}")/*, Authorize(Roles = "Admin")*/]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct(int Id)
        {
            var result = await _appointment.DeleteAppointment(Id);
            return Ok(result);
        }
    }
}

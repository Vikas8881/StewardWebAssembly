using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;
using StewardAPI.Repository.IDoctorRepository;
using Stripe;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Doctor>>>>addDoctor(Doctor doctor)
        {
            var result = await _doctorRepository.CreateDoctor(doctor);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<DoctorDTO>>>> GetDoctors()
        {
            
            var result = await _doctorRepository.GetDoctorHospital();
            return Ok(result);
        }
        [HttpPut/*, Authorize(Roles = "Admin")*/]
        public async Task<ActionResult<ServiceResponse<Doctor>>> UpdateDoctors(Doctor doctor)
        {
            var result = await _doctorRepository.UpdateDoctor(doctor);
            return Ok(result);
        }
        [HttpDelete("{Id}")/*, Authorize(Roles = "Admin")*/]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct(int Id)
        {
            var result = await _doctorRepository.DeleteDoctor(Id);
            return Ok(result);
        }
    }
}

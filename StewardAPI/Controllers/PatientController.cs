using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;

using StewardAPI.Repository.PatientRepository;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        [HttpGet("Hospital")]
        public async Task<ActionResult<ServiceResponse<List<Patient>>>> GetPatientByHospitalID()
        {
            var result = await _patientRepository.GetByHospital();
            return Ok(result);
        }
        [HttpGet("ID")]
        public async Task<ActionResult<ServiceResponse<Patient>>> GetPatientByID(int ID)
        {
            var result = await _patientRepository.GetPatient(ID);
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult<ServiceResponse<PatientCreateDTO>>> CreatePatient(PatientCreateDTO patient)
        {
            var result = await _patientRepository.CreatePatient(patient);
            return Ok(result);
        }
        [HttpPost]
        [Route("PatientwithUHID")]
        public async Task<ActionResult<ServiceResponse<Patient>>> PostPatientwithUHID(PatientCreateDTO patient)
        {
            var result = await _patientRepository.PostPatientwithUHID(patient);
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Patient>>> UpdatePatient(Patient patient)
        {
            var result = await _patientRepository.UpdatePatient(patient);
            return Ok(result);
        }
        [HttpDelete("ID")]
        public async Task<ActionResult<ServiceResponse<Patient>>> DeletePatient(int ID)
        {
            var result = await _patientRepository.DeletePatient(ID);
            return Ok(result);
        }

        [HttpGet("uid")]
        //[Route("uid/{Uhid:int}")]
        public async Task<ActionResult<ServiceResponse<Patient>>> GetPatientByUHID(int uhid)
        {
            var result = await _patientRepository.SearchPatientUhid(uhid);
            return Ok(result);
        }
    }
}

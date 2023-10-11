using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;
using StewardAPI.Models;
using StewardAPI.Repository.prescription;
using StewardAPI.Repository.User;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientComplaintController : ControllerBase
    {
        private readonly IComplaintRepo _complaintRepo;
        public PatientComplaintController(IComplaintRepo complaintRepo)
        {
            _complaintRepo = complaintRepo;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<pComplain>>> Create(pComplain complain)
        {
            var response = await _complaintRepo.Create(complain);
            return Ok(response);
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using StewardAPI.Repository.DepartmentRepo;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Department>>>>GetDepartments()
        {
            var result=await _departmentRepository.GetDepartments();
            return Ok(result);
        }
        [HttpGet("admin")]
        [Authorize]
        public async Task<ActionResult<ServiceResponse<List<Department>>>> GetDepartmentsAdmin()
        {
            var result = await _departmentRepository.GetDepartmentAdmin();
            return Ok(result);
        }
        [HttpDelete("admin")]
        [Authorize]
        public async Task<ActionResult<ServiceResponse<List<Department>>>>DeleteDepartment(int departmentId) 
        {
            var result=await _departmentRepository.DeleteDepartment(departmentId);
            return Ok(result);
        }
        [HttpPost("admin")]
        public async Task<ActionResult<ServiceResponse<List<Department>>>>AddDepartment(Department departments)
        {
            var result = await _departmentRepository.AddDepartment(departments);
            return Ok(result);
        }
        [HttpPut("admin")]
        [Authorize]
        public async Task<ActionResult<ServiceResponse<List<Department>>>> UpdateDepartment(Department department)
        {
            var result=await _departmentRepository.UpdateDepartment(department);
            return Ok(result);
        }
    }

}

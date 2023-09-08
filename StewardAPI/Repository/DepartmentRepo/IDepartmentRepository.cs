using Model;
using StewardAPI.Migrations;

namespace StewardAPI.Repository.DepartmentRepo
{
    public interface IDepartmentRepository
    {
        Task<ServiceResponse<List<Department>>> GetDepartments();
        Task<ServiceResponse<List<Department>>> GetDepartmentAdmin();
        Task<ServiceResponse<List<Department>>>AddDepartment(Department departments);
        Task<ServiceResponse<List<Department>>>UpdateDepartment(Department departments);
        Task<ServiceResponse<List<Department>>>DeleteDepartment(int departmentId);
        Task<Department> GetDepartmentById(int departmentId);
    }
}

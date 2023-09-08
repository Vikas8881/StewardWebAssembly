using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;
using StewardAPI.Migrations;
using StewardAPI.Repository.User;

namespace StewardAPI.Repository.DepartmentRepo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _AppDbContext;
        private readonly IUserService _userService;

        public DepartmentRepository(AppDbContext AppDbContext, IUserService userService)
        {
            _AppDbContext = AppDbContext;
            _userService = userService;
        }
        public async Task<ServiceResponse<List<Department>>> AddDepartment(Department departments)
        {
            departments.Editing = departments.IsNew = false;
            departments.Deleted = false;
            departments.hospitalID= _userService.GetUserID();
            _AppDbContext.Departments.Add(departments);
            await _AppDbContext.SaveChangesAsync();
            return await GetDepartmentAdmin();
        }

        public async Task<ServiceResponse<List<Department>>> DeleteDepartment(int departmentId)
        {
            Department department = await GetDepartmentById(departmentId);
            if (department == null)
            {
                return new ServiceResponse<List<Department>>
                {
                    Success = false,
                    Message = "Department not found!"
                };
            }
            department.Deleted = true;
            await _AppDbContext.SaveChangesAsync();
            return await GetDepartmentAdmin();
        }

        public async Task<ServiceResponse<List<Department>>> GetDepartmentAdmin()
        {
            var department = await _AppDbContext.Departments
                   .Where(c => !c.Deleted).ToListAsync();
            return new ServiceResponse<List<Department>>
            {
                Data = department
            };
        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _AppDbContext.Departments.FirstOrDefaultAsync(d => d.Id == departmentId);
        }

        public async Task<ServiceResponse<List<Department>>> GetDepartments()
        {
            var department = await _AppDbContext.Departments
                .Where(c => !c.Deleted && c.Visible).ToListAsync();
            return new ServiceResponse<List<Department>>
            {
                Data = department
            };
        }

        public async Task<ServiceResponse<List<Department>>> UpdateDepartment(Department departments)
        {
            var dbDepartment = await GetDepartmentById(departments.Id);
            if (dbDepartment == null)
            {
                return new ServiceResponse<List<Department>>
                {
                    Success = false,
                    Message = "Department not found."
                };
            }
            dbDepartment.Name = departments.Name;
            dbDepartment.Description = departments.Description;
            dbDepartment.Visible=departments.Visible;
            await _AppDbContext.SaveChangesAsync();
            return await GetDepartmentAdmin();
        }
    }
}

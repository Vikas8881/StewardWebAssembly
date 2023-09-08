using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;
using StewardAPI.Dto;
using StewardAPI.Repository.User;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace StewardAPI.Repository.IDoctorRepository
{
    public class DoctorRepo : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;

        public DoctorRepo(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }
        public async Task<ServiceResponse<Doctor>> CreateDoctor(Doctor doctor)
        {
            doctor.hospitalID = _userService.GetUserID();
            _appDbContext.Doctors.Add(doctor);

            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<Doctor>
            {
                Data = doctor
            };
        }

        public async Task<ServiceResponse<bool>> DeleteDoctor(int doctorID)
        {
            var Dbdoctor = await _appDbContext.Doctors.FindAsync(doctorID);
            if (Dbdoctor == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Doctor Not Found."
                };
            }
            Dbdoctor.Deleted = true;
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true
            };
        }

        public async Task<ServiceResponse<List<Doctor>>> GetAdminDoctors()
        {
            var response = new ServiceResponse<List<Doctor>>
            {
                Data = await _appDbContext.Doctors
               .Where(d => !d.Deleted).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Doctor>> GetDoctor(int Id)
        {
            var response = new ServiceResponse<Doctor>();
            Doctor doctor = null;
            if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                doctor = await _appDbContext.Doctors
                    .FirstOrDefaultAsync(d => d.Id == Id && !d.Deleted);
            }
            else
            {
                doctor = await _appDbContext.Doctors
                     .FirstOrDefaultAsync(d => d.Id == Id && !d.Deleted && d.Visible);
            }
            if (doctor == null)
            {
                response.Success = false;
                response.Message = "Sorry doctor not exists.";
            }
            else
            {
                response.Data = doctor;
            }
            return response;
        }

        //public async Task<ServiceResponse<List<Doctor>>> GetDoctorByDepartment(string departmentUrl)
        //{
        //   // var response = new ServiceResponse<List<Doctor>>
        //   // {
        //   //     Data = await _appDbContext.Doctors.Where
        //   //     (d=>d.Department.Equals(departmentUrl)
                
        //   //     )
                

        //   //}
        //}

        public async Task<ServiceResponse<List<Doctor>>> GetDoctorHospital(/*string hospitalID*/)
        {
           string hospitalID = _userService.GetUserID();

            var doctor = await _appDbContext.Doctors
              .Where(c => !c.Deleted && c.hospitalID==hospitalID)
              .ToListAsync();

            if (doctor != null)
            {
                return new ServiceResponse<List<Doctor>>
                {
                    Data = doctor,
                    Success = true
                };
            }
            else
            {
                return new ServiceResponse<List<Doctor>>
                {
                    Success = false,
                    Message="No Record Found."
                };
            }

        }

        public Task<ServiceResponse<List<string>>> GetDoctorSearchSuggestions(string SearchText)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Doctor>> UpdateDoctor(Doctor doctor)
        {
            var dbDoctor=await _appDbContext.Doctors.FirstOrDefaultAsync(d=>d.Id==doctor.Id);
            if (dbDoctor == null)
            {
                return new ServiceResponse<Doctor>
                { Success = false,
                Message="Doctor not found!"
                };
            }
            dbDoctor.DoctorName = doctor.DoctorName;
            dbDoctor.Department=dbDoctor.Department;
            dbDoctor.Fees= dbDoctor.Fees;
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<Doctor>
            {
                Success = true,
                Data = doctor
            };
        }
    }
}

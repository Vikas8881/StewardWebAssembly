using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;
using StewardAPI.Repository.User;

namespace StewardAPI.Repository.AppointmentRepo
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        public AppointmentRepository(AppDbContext appDbContext, IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = appDbContext;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ServiceResponse<AppointmentModel>> CreateAppointment(AppointmentModel appointment)
        {
            string hospitalID = _userService.GetUserID();
            appointment.hospitalID = hospitalID;
            //appointment.confirmation = "Pending!";
            await _appDbContext.Appointments.AddAsync(appointment);

            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<AppointmentModel>
            {
                Data = appointment
            };

        }

        public Task<ServiceResponse<bool>> DeleteAppointment(int appointmentID)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<AppointmentModel>>> GetAdminAppointment()
        {
            var response = new ServiceResponse<List<AppointmentModel>>
            {
                Data = await _appDbContext.Appointments
               .Where(d => !d.Deleted).ToListAsync()
            };
            return response;

        }

        public async Task<ServiceResponse<AppointmentModel>> GetAppointment(int Id)
        {

            var response = new ServiceResponse<AppointmentModel>();
            AppointmentModel appointmentModel = null;
            if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                appointmentModel = await _appDbContext.Appointments
                    .FirstOrDefaultAsync(d => d.ID == Id && !d.Deleted);
            }
            else
            {
                appointmentModel = await _appDbContext.Appointments
                     .FirstOrDefaultAsync(d => d.ID == Id && !d.Deleted);
            }
            if (appointmentModel == null)
            {
                response.Success = false;
                response.Message = "Sorry appointment not exists.";
            }
            else
            {
                response.Data = appointmentModel;
            }
            return response;
        }

        public async Task<ServiceResponse<List<AppointmentModel>>> GetAppointmentHospital()
        {
            string hospitalID = _userService.GetUserID();

            var appointment = await _appDbContext.Appointments
            .Where(c => !c.Deleted && c.hospitalID == hospitalID)
            .ToListAsync();
            //var dto=_mapper.Map<DoctorDTO>(doctor);
            return new ServiceResponse<List<AppointmentModel>>
            {
                Data = appointment,
                Success = true,
            };
        }

        public async Task<ServiceResponse<AppointmentModel>> UpdateAppointment(AppointmentModel appointment)
        {
            var dbAppointment = await _appDbContext.Appointments.FirstOrDefaultAsync(d => d.ID == appointment.ID);
            if (dbAppointment == null)
            {
                return new ServiceResponse<AppointmentModel>
                {
                    Success = false,
                    Message = "Doctor not found!"
                };
            }
            dbAppointment.Name = dbAppointment.Name;
            dbAppointment.phone = dbAppointment.phone;
            dbAppointment.Address = dbAppointment.Address;
            dbAppointment.City = dbAppointment.City;
            //dbAppointment.Doctor = dbAppointment.Doctor;
            dbAppointment.AppointmentType = dbAppointment.AppointmentType;
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<AppointmentModel>
            {
                Success = true,
                Data = appointment
            };
        }
    }
}

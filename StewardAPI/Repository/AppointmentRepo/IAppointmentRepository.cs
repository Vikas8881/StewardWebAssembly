using Model;
using System.Numerics;

namespace StewardAPI.Repository.AppointmentRepo
{
    public interface IAppointmentRepository
    {
        Task<ServiceResponse<AppointmentModel>> GetAppointment(int Id);
        Task<ServiceResponse<List<AppointmentModel>>> GetAppointmentHospital();

        Task<ServiceResponse<List<AppointmentModel>>> GetAdminAppointment();
        Task<ServiceResponse<AppointmentModel>> CreateAppointment(AppointmentModel appointment);
        Task<ServiceResponse<AppointmentModel>> UpdateAppointment(AppointmentModel appointment);
        Task<ServiceResponse<bool>> DeleteAppointment(int appointmentID);
    }
}

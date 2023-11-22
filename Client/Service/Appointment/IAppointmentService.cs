using Model;

namespace Client.Service.Appointment
{
    public interface IAppointmentService
    {
        event Action OnChange;
        List<AppointmentModel> Appointmentlist { get; set; }
        List<AppointmentModel> AdminAppointments { get; set; }
        Task GetAdminAppointment();
        Task<AppointmentModel> AddAppointment(AppointmentModel AddAppointment);

        Task UpdateAppointment(AppointmentModel UpdateAppointment);
        Task DeleteAppointment(int appointmentId);
        
        Task GetAppointments();
    }
}

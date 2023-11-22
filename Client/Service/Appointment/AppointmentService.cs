using Client.Service.PatientRepo;
using Model;
using System.Net.Http.Json;

namespace Client.Service.Appointment
{
    public class AppointmentService : IAppointmentService
    {
        private readonly HttpClient _httpClient;

        public AppointmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<AppointmentModel> Appointmentlist { get; set; }
        public List<AppointmentModel> AdminAppointments { get; set; }

        public event Action OnChange;

        public async Task<AppointmentModel> AddAppointment(AppointmentModel AddAppointment)
        {
            var result = await _httpClient.PostAsJsonAsync("Appointment", AddAppointment);
            var newAppointment = (await result.Content.ReadFromJsonAsync<ServiceResponse<AppointmentModel>>()).Data;
            return newAppointment;
        }

        public Task DeleteAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Task GetAdminAppointment()
        {
            throw new NotImplementedException();
        }

        public async Task GetAppointments()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<AppointmentModel>>>("Appointment");
            if (response != null && response.Data != null)
            {
                Appointmentlist = response.Data;
            }
        }

        public Task UpdateAppointment(AppointmentModel UpdateAppointment)
        {
            throw new NotImplementedException();
        }
    }
}

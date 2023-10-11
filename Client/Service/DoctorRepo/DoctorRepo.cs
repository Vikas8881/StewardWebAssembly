using Model;
using Model.DTO;
using System.Net.Http.Json;

namespace Client.Service.DoctorRepo
{
    public class DoctorRepo : iDoctorRepo
    {
        private readonly HttpClient _httpClient;

        public DoctorRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Doctor> Doctors { get; set; }=new List<Doctor>();
        public List<Doctor> AdminDoctors { get; set; }

        public event Action OnChange;

        public Task AddDoctor(Doctor category)
        {
            throw new NotImplementedException();
        }

        public Doctor CreateNewDoctor()
        {
            throw new NotImplementedException();
        }

        public Task DeleteDoctor(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task GetAdminDoctor()
        {
            throw new NotImplementedException();
        }

        public async Task GetDoctor()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Doctor>>>("Doctor");
            if(response !=null && response.Data != null)
            {
                Doctors = response.Data;
            }
        }

        public Task UpdateDoctor(Doctor category)
        {
            throw new NotImplementedException();
        }
    }
}

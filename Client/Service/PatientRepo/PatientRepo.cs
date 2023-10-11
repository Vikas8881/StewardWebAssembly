using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientRepo
{
    public class PatientRepo : IPatient
    {
        private readonly HttpClient _httpClient;

        public PatientRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //public List<Patient> Patients { get; set; }
        public string Message { get; set; } = "Loading...";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;

        public event Action PatientChagned;
        public List<Patient> PatientList { get; set; }
        public async Task<Patient> CreatePatient(Patient patient)
        {
            var result = await _httpClient.PostAsJsonAsync("Patient", patient);
            var newPatient= (await result.Content.ReadFromJsonAsync<ServiceResponse<Patient>>()).Data;
            return newPatient;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetPatientList()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Patient>>>("Patient/Hospital");
            PatientList = response.Data;
            CurrentPage = 1;
            PageCount= 0;
            if(PatientList.Count==0)
            {
                Message = "No Patient Found!";
            }
           
        }

        public Task<Patient> UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Patient>> GetPatientbyUhid(int uhid)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Patient>>($"Patient/uid?uhid={uhid}");
            return result;
        }

        public async Task<Patient> CreatePatientUhid(Patient patient)
        {
            var result = await _httpClient.PostAsJsonAsync("Patient/PatientwithUHID", patient);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<Patient>>()).Data;
            return newPatient;
        }

        public async Task<ServiceResponse<Patient>> GetPatient(int ID)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Patient>>($"Patient/ID?ID={ID}");
            return result;
        }
    }
}

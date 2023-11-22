using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public class PatientMedicineRepo : IPatientMedicineRepo
    {
        private readonly HttpClient _httpClient;

        public PatientMedicineRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PatientMedicines> CreatePatientMedicine(PatientMedicines patientMedicines)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint/PatientMedicineCreate", patientMedicines);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<PatientMedicines>>()).Data;
            return newPatient;
        }

        public async Task<ServiceResponse<List<PatientMedicines>>> GetMedicines(int ID)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<PatientMedicines>>>($"PatientComplaint/getMedicines?PID={ID}");
            return result;
        }
    }
}

using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public class PatientDiagnosisRepo : IPatientDiagnosisRepo
    {
        private readonly HttpClient _httpClient;
        public PatientDiagnosisRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<pDignosis> CreateDiagnosis(pDignosis pDignosis)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint/DiagnosisCreate", pDignosis);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<pDignosis>>()).Data;
            return newPatient;
        }
    }
}

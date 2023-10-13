using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public class PatientAdviceRepo : IPatientAdviceRepo
    {
        private readonly HttpClient _httpClient;
        public PatientAdviceRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<pAdvice> CreateAdvice(pAdvice pAdvice)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint/AdviceCreate", pAdvice);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<pAdvice>>()).Data;
            return newPatient;
        }

    }
}

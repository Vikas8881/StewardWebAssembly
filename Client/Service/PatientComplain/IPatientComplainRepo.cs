using Client.Service.PatientRepo;
using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public interface IPatientComplainRepo
    {
        Task<pComplain> CreateComplain(pComplain pComplain);
    }
    public class PatientComplainRepo : IPatientComplainRepo
    {
        private readonly HttpClient _httpClient;
        public PatientComplainRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<pComplain> CreateComplain(pComplain pComplain)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint", pComplain);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<pComplain>>()).Data;
            return newPatient;
        }
    }
}

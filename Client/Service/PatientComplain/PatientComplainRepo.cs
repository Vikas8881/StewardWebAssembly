using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public class PatientComplainRepo : IPatientComplainRepo
    {
        private readonly HttpClient _httpClient;
        public PatientComplainRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<pComplain> CreateComplain(pComplain pComplain)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint/ComplaintCreate", pComplain);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<pComplain>>()).Data;
            return newPatient;
        }

        public async Task<ServiceResponse<List<GenComplaints>>> GetComplain(int ID)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenComplaints>>>($"PatientComplaint/getComplaints?PID={ID}");
            return result;
        }

        //public async Task<ServiceResponse<GenComplaints>> GetComplain(int ID)
        //{
        //    var result = await _httpClient.GetFromJsonAsync<ServiceResponse<GenComplaints>>($"PatientComplaint/getComplaints?PID={ID}");
        //    return result;
        //}

    }
}

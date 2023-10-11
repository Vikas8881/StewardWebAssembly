
using Client.Service.PatientRepo;
using Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.Service.Global
{
    public class GlobalComplaintRepo : IGlobalComplaint
    {
        private readonly HttpClient _httpClient;
        public GlobalComplaintRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<GenComplaints> GenComplaintsList { get; set; }
        public async Task<GenComplaints> Create(GenComplaints genComplaint)
        {
            var result = await _httpClient.PostAsJsonAsync("Globalissues/GComplainCreate", genComplaint);
            var newComplaint = (await result.Content.ReadFromJsonAsync<ServiceResponse<GenComplaints>>()).Data;
            return newComplaint;
        }

        public async Task<ServiceResponse<List<GenComplaints>>> GetComplaints()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenComplaints>>>("Globalissues/GComplainget");
            return result;
        }
    }
}

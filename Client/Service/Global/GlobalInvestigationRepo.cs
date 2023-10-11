
using Client.Service.PatientRepo;
using Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.Service.Global
{
    public class GlobalInvestigationRepo : IGlobalInvestigation
    {
        private readonly HttpClient _httpClient;
        public GlobalInvestigationRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<GenLabInvestigation> GenlabInvestigation { get; set; }
        public async Task<GenLabInvestigation> Create(GenLabInvestigation genInvestigation)
        {
            var result = await _httpClient.PostAsJsonAsync("Globalissues/GInvestigationCreate", genInvestigation);
            var newComplaint = (await result.Content.ReadFromJsonAsync<ServiceResponse<GenLabInvestigation>>()).Data;
            return newComplaint;
        }
        public async Task<ServiceResponse<List<GenLabInvestigation>>> GetlabInvestigation()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenLabInvestigation>>>("Globalissues/GInvestigationget");
            return result;
        }
    }
}

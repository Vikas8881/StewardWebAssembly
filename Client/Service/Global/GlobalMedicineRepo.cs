
using Client.Service.PatientRepo;
using Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.Service.Global
{
    public class GlobalMedicineRepo : IGlobalMedicine
    {
        private readonly HttpClient _httpClient;
        public GlobalMedicineRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<GenMedicine> GenMedicine { get; set; }
        public async Task<GenMedicine> Create(GenMedicine genGenmedicine)
        {
            var result = await _httpClient.PostAsJsonAsync("Globalissues/GMedicineCreate", genGenmedicine);
            var newComplaint = (await result.Content.ReadFromJsonAsync<ServiceResponse<GenMedicine>>()).Data;
            return newComplaint;
        }

        public async Task<ServiceResponse<List<GenMedicine>>> GetMedicine()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenMedicine>>>("Globalissues/GMedicineget");
            return result;
        }
    }
}

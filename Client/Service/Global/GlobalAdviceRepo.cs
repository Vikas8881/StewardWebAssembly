
using Client.Service.PatientRepo;
using Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.Service.Global
{
    public class GlobalAdviceRepo : IGlobalAdvice
    {
        private readonly HttpClient _httpClient;
        public GlobalAdviceRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<GenAdvice> GenGetAdvice { get; set; }
        public async Task<GenAdvice> Create(GenAdvice genAdvice)
        {
            var result = await _httpClient.PostAsJsonAsync("Globalissues/GAdviceCreate", genAdvice);
            var newComplaint = (await result.Content.ReadFromJsonAsync<ServiceResponse<GenAdvice>>()).Data;
            return newComplaint;
        }
        public async Task<ServiceResponse<List<GenAdvice>>> GetAdvice()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenAdvice>>>("Globalissues/GAdviceget");
            return result;
        }
    }
}

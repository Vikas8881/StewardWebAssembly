
using Client.Service.PatientRepo;
using Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.Service.Global
{
    public class GlobalDignosisRepo : IGlobalDignosis
    {
        private readonly HttpClient _httpClient;
        public GlobalDignosisRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<GenDignosis> GenGetDignosis { get; set; }
        public async Task<GenDignosis> Create(GenDignosis genDignosis)
        {
            var result = await _httpClient.PostAsJsonAsync("Globalissues/GDignosisCreate", genDignosis);
            var newComplaint = (await result.Content.ReadFromJsonAsync<ServiceResponse<GenDignosis>>()).Data;
            return newComplaint;
        }

        public async Task<ServiceResponse<List<GenDignosis>>> GetDignosis()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenDignosis>>>("Globalissues/GDignosisget");
            return result;
        }
    }
}

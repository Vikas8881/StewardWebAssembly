﻿using Model;
using System.Net.Http.Json;

namespace Client.Service.PatientComplain
{
    public class PatientInvestigationRepo : IPatientInvestigationRepo
    {
        private readonly HttpClient _httpClient;
        public PatientInvestigationRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<pInvestigation> CreateInvestigation(pInvestigation pInvestigation)
        {
            var result = await _httpClient.PostAsJsonAsync("PatientComplaint/InvestigationCreate", pInvestigation);
            var newPatient = (await result.Content.ReadFromJsonAsync<ServiceResponse<pInvestigation>>()).Data;
            return newPatient;
        }

        public async Task<ServiceResponse<List<GenLabInvestigation>>> GetInvestigation(int ID)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<GenLabInvestigation>>>($"PatientComplaint/getInvestigations?PID={ID}");
            return result;
        }
    }
}

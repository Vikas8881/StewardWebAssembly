using Microsoft.AspNetCore.Components.Authorization;
using Model;
using Model.DTO;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Client.Service.authenticationService
{
    public interface IauthenticationService
    {
        Task<ServiceResponse<string>> Register(RegistrationDTO request);
        Task<ServiceResponse<string>> Login(LoginUserDto loginUser);
    }
    public class authenticationService : IauthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public authenticationService(HttpClient httpClient,AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<ServiceResponse<string>> Login(LoginUserDto request)
        {
            var result = await _httpClient.PostAsJsonAsync("Auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();

        }

        public async Task<ServiceResponse<string>> Register(RegistrationDTO request)
        {
            var result = await _httpClient.PostAsJsonAsync("Auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();

        }
    }
}

using Proxima.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Proxima.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        //private readonly AppSettingsService _appSettings;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider,
                              ILocalStorageService localStorage /*,AppSettingsService appSettings*/)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
            //_appSettings = appSettings;
        }


        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await _httpClient.PostJsonAsync<RegisterResult>("api/accounts", registerModel);

            return result;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Supprimer les objets avant la mise hors de portée", Justification = "<En attente>")]
        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var loginAsJson = JsonSerializer.Serialize(loginModel);
            var response = await _httpClient.PostAsync(/*_appSettings + */"api/Login", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<LoginResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await _localStorage.SetItemAsync("authToken", loginResult.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Name);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<T> GetJsonAsync<T>(Uri requestUri)
        {
            //Uri RequestUri = new Uri(_appSettings + requestUri.ToString());
            var httpContent = await _httpClient.GetAsync(requestUri);
            string jsonContent = httpContent.Content.ReadAsStringAsync().Result;
            T obj = JsonConvert.DeserializeObject<T>(jsonContent);
            return obj;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Supprimer les objets avant la mise hors de portée", Justification = "<En attente>")]
        public async Task<HttpResponseMessage> PostJsonAsync<T>(Uri requestUri, T content)
        {
            //Uri RequestUri = new Uri(_appSettings + requestUri.ToString());
            string myContent = JsonConvert.SerializeObject(content);
            StringContent stringContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(requestUri, stringContent);
            return response;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Supprimer les objets avant la mise hors de portée", Justification = "<En attente>")]
        public async Task<HttpResponseMessage> PutJsonAsync<T>(Uri requestUri, T content)
        {
            //Uri RequestUri = new Uri(_appSettings + requestUri.ToString());
            string myContent = JsonConvert.SerializeObject(content);
            StringContent stringContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(requestUri, stringContent);
            return response;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Supprimer les objets avant la mise hors de portée", Justification = "<En attente>")]
        public async Task<HttpResponseMessage> DeleteJsonAsync(Uri requestUri)
        {
            var response = await _httpClient.DeleteAsync(requestUri);
            return response;
        }
    }
}

using ForceT.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ForceT.Client.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        //Task<RegisterResult> Register(RegisterModel registerModel);
        Task<T> GetJsonAsync<T>(Uri requestUri);
        Task<HttpResponseMessage> PostJsonAsync<T>(Uri requestUri, T content);
        Task<HttpResponseMessage> PutJsonAsync<T>(Uri requestUri, T content);
        Task<HttpResponseMessage> DeleteJsonAsync(Uri requestUri);
    }
}

using Microsoft.Extensions.Configuration;

namespace ForceT.Client.Services
{
    public class AppSettingsService
    {
        private readonly IConfiguration _config;
        public AppSettingsService(IConfiguration config)
        {
            _config = config;
        }
        public string GetBaseUrl()
        {
            return _config["BaseUrl"];
        }
    }
}

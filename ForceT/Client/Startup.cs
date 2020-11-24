using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using ForceT.Client.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Microsoft.AspNetCore.Components;
using BlazorDataGrid.Services;
using Microsoft.AspNetCore.Builder;

namespace ForceT.Client
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<AppSettingsService>();
            if (!services.Any(x => x.ServiceType == typeof(HttpClient)))
            {
                // Setup HttpClient for server side in a client side compatible fashion
                services.AddScoped<HttpClient>(s =>
                {
                    // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
                    var uriHelper = s.GetRequiredService<NavigationManager>();
                    return new HttpClient
                    {
                        BaseAddress = new Uri(uriHelper.BaseUri)
                    };
                });
            }
            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddRoles<IdentityRole>();
            services.AddBlazoredLocalStorage();
            services.AddAuthorizationCore();
            services.AddScoped<AppState, AppState>();
            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddScoped<IAuthService, AuthService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

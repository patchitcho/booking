#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexVehicule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86824113ffc840c9e464d7f3c913304cdfee0f08"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ForceT.Client.Pages.Sondage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexVehicule.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vehicule")]
    public partial class IndexVehicule : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexVehicule.razor"
       

    Vehicule[] vehicules;
    Vehicule vehicule = new Vehicule();
    private bool hidden = false;
    string adr;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response;
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Vehicules";
        //zones = await AuthService.GetJsonAsync<Vehicule[]>(new Uri(adr21));
        //try
        //{
        response = await Http.GetAsync("api/Vehicules");
        //response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            //vehicules = await JsonSerializer.DeserializeAsync<Vehicule[]>(responseContent);
            vehicules = JsonConvert.DeserializeObject<Vehicule[]>(jsonContent);
        }
        else
        {
            adr = response.RequestMessage.ToString();
        }
        //}
        //catch (Exception e)
        //{
        //    adr = e.Message;
        //}
    }

    private void PrepareForEdit(Vehicule vehiculeedit)
    {
        vehicule = vehiculeedit;
    }
    private void PrepareForDelete(Vehicule vehiculedelete)
    {
        vehicule = vehiculedelete;
    }

    private async void DataChanged()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Vehicules";
        vehicules = await AuthService.GetJsonAsync<Vehicule[]>(new Uri(adr21));
        StateHasChanged();
    }

    private async Task Delete()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Vehicules/" + vehicule.VehiculeId;
        var task = await AuthService.DeleteJsonAsync(new Uri(adr21));
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "confirmDeleteModal");
        DataChanged();
        vehicule = new Vehicule();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
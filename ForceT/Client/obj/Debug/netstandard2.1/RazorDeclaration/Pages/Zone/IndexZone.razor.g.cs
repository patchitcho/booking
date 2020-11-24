#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Zone\IndexZone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510af863bb350dd483893d0ef6ae86ca2594d4f7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ForceT.Client.Pages.Zone
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.Datatable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using BlazorDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.AutoComplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.RolesUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Zone\IndexZone.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zone")]
    public partial class IndexZone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Zone\IndexZone.razor"
       

    Zone[] zones;
    List<Zone> zoo;
    Zone zone = new Zone();
    private bool hidden = false;
    string adr;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response;
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Zones";

        response = await Http.GetAsync("api/Zones");

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            //zones = await JsonSerializer.DeserializeAsync<Zone[]>(responseContent);
            zones = JsonConvert.DeserializeObject<Zone[]>(jsonContent);
            zoo = JsonConvert.DeserializeObject<List<Zone>>(jsonContent);
        }
        else
        {
            adr = response.RequestMessage.ToString();
        }
    }

    private Dictionary<string, string> translate = new Dictionary<string, string>
{
        {"next", "Suivant" },
        {"previous", "Precedant" },
        {"pages", "Page __curpage__ de __totalpages__" },
        {"totalresult", "__totalcount__ ligne" },
        {"totalresultplural", "__totalcount__ lignes"},
        {"filteredresults", "__filteredcount__ result de __totalcount__ lignes" },
        {"filteredresultsplural", "__filteredcount__ results de __totalcount__ lignes"  },
        {"selector", "lignes par page :" }
    };

    private Dictionary<string, int> PageSelector = new Dictionary<string, int>
{
        {"5", 5 },
        {"10", 10 },
        {"20", 20 },
        {"30", 30 },
        {"Tout", 0 }
    };

    private void PrepareForEdit(Zone zoneedit)
    {
        zone = zoneedit;
    }

    private void PrepareForDelete(Zone zonedelete)
    {
        zone = zonedelete;
    }

    private async void DataChanged()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Zones";
        zones = await AuthService.GetJsonAsync<Zone[]>(new Uri(adr21));
        StateHasChanged();
    }

    private async Task Delete()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Zones/" + zone.zoneId;
        var task = await AuthService.DeleteJsonAsync(new Uri(adr21));
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "confirmDeleteModal");
        DataChanged();
        zone = new Zone();
    }

    public async Task CreatePdf()
    {
        HttpResponseMessage response;
        ReportResult rpt = new ReportResult();
        response = await Http.GetAsync("api/Zones/exportpdf");

        if (response.IsSuccessStatusCode)
        {
            string jsonContentPdf = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            rpt = JsonConvert.DeserializeObject<ReportResult>(jsonContentPdf);
        }
        else
        {
            adr = response.RequestMessage.ToString();
        }

        string pdfName = $"Liste des zones-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.pdf";
        await JSRuntime.InvokeAsync<object>("JsFunctions.saveAsFile", pdfName, Convert.ToBase64String(rpt.stream.ToArray()));
    }

    public async Task ExportExcel()
    {
        HttpResponseMessage response;
        ReportResult rpt = new ReportResult();
        response = await Http.GetAsync("api/Zones/exportexcel");

        if (response.IsSuccessStatusCode)
        {
            string jsonContentexcel = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            rpt = JsonConvert.DeserializeObject<ReportResult>(jsonContentexcel);
        }
        else
        {
            adr = response.RequestMessage.ToString();
        }

        string excelName = $"Liste des zones-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
        await JSRuntime.InvokeAsync<object>("JsFunctions.saveAsFile", excelName, Convert.ToBase64String(rpt.stream.ToArray()));
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

#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f691fcd3f37b761113a397e9d215941b1959f2d3"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Tournée
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
#line 4 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tournee")]
    public partial class IndexTourne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Liste des tournées</h3>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<p>\r\n            <a href=\"CreationTournee\">Créer une nouvelle tournée</a>\r\n        </p>\r\n");
#nullable restore
#line 19 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
         if (tournees == null)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.Annimation>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 32 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "confluid");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "id", "indexzone");
            __builder.AddAttribute(18, "class", "table table-bordered table-responsive-xl");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.AddMarkupContent(20, "<thead>\r\n                        <tr>\r\n                            <th>Nom</th>\r\n                            <th>Date</th>\r\n                            <th>Type</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 57 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                         foreach (var tournee in tournees)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                            ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 60 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                     tournee.Libellé

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 61 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                     tournee.Date_tournee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 62 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                     tournee.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "style", "width:100px");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                                                                                               (() => PrepareForEdit(tournee))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "data-toggle", "modal");
            __builder.AddAttribute(42, "data-target", "#DetailTourne");
            __builder.AddAttribute(43, "value", "Editer");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "style", "width:100px");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-danger");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                                                                                              (() => PrepareForDelete(tournee))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "data-toggle", "modal");
            __builder.AddAttribute(52, "data-target", "#confirmDeleteModal");
            __builder.AddAttribute(53, "value", "Supprimer");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 66 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Tournée.DetailTourne>(60);
            __builder.AddAttribute(61, "tournee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForceT.Shared.Models.Tournee>(
#nullable restore
#line 70 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                   tournee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "DataChanged", new System.Action(
#nullable restore
#line 70 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                                          DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.ConfirmDialog>(64);
            __builder.AddAttribute(65, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
                                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 72 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\IndexTourne.razor"
       

    Tournee[] tournees;
    Tournee tournee = new Tournee();
    private bool hidden = false;
    string adr;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response;
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Tournees";
        //zones = await AuthService.GetJsonAsync<Vehicule[]>(new Uri(adr21));
        //try
        //{
        response = await Http.GetAsync("api/Tournees");
        //response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            //tournees = await JsonSerializer.DeserializeAsync<Tournee[]>(responseContent);
            tournees = JsonConvert.DeserializeObject<Tournee[]>(jsonContent);
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

    private void PrepareForEdit(Tournee tourneedit)
    {
        tournee = tourneedit;
    }
    private void PrepareForDelete(Tournee tourneedelete)
    {
        tournee = tourneedelete;
    }

    private async void DataChanged()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Tournees";
        tournees = await AuthService.GetJsonAsync<Tournee[]>(new Uri(adr21));
        StateHasChanged();
    }

    private async Task Delete()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Tournees/" + tournee.TourneeId;
        var task = await AuthService.DeleteJsonAsync(new Uri(adr21));
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "confirmDeleteModal");
        DataChanged();
        tournee = new Tournee();
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

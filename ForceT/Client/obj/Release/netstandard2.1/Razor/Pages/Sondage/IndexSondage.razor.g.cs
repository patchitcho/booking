#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "966ef01cf1449fde60cf68d546d9840aa5ceeafd"
// <auto-generated/>
#pragma warning disable 1591
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
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.Datatable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using BlazorDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.AutoComplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile.RolesUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sondage")]
    public partial class IndexSondage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Liste des sondages</h3>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<p>\r\n            <a href=\"CreationSondage\">Créer un nouveau sondage</a>\r\n        </p>\r\n");
#nullable restore
#line 19 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
         if (sondages == null)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.Annimation>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 32 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
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
            __builder.AddMarkupContent(20, @"<thead class=""thead-light"">
                        <tr style=""height:18px"">
                            <th>Nom</th>
                            <th>Question</th>
                            <th>Type</th>
                            <th>Status</th>
                            <th>Obligatoire</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 47 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                         foreach (var sondage in sondages)
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
#line 50 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     sondage.Libellé

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     sondage.Question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     sondage.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 53 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     sondage.Statut

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 54 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     sondage.Obligatoire

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "style", "width:100px");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                                                                                               (() => PrepareForEdit(sondage))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "data-toggle", "modal");
            __builder.AddAttribute(48, "data-target", "#DetailSondage");
            __builder.AddAttribute(49, "value", "Editer");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "style", "width:100px");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-danger");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                                                                                              (() => PrepareForDelete(sondage))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "data-toggle", "modal");
            __builder.AddAttribute(58, "data-target", "#confirmDeleteModal");
            __builder.AddAttribute(59, "value", "Supprimer");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 58 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Sondage.DetailSondage>(66);
            __builder.AddAttribute(67, "sondage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForceT.Shared.Models.Sondage>(
#nullable restore
#line 62 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                    sondage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "DataChanged", new System.Action(
#nullable restore
#line 62 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                                           DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.ConfirmDialog>(70);
            __builder.AddAttribute(71, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
                                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 64 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Sondage\IndexSondage.razor"
       

    Sondage[] sondages;
    Sondage sondage = new Sondage();
    private bool hidden = false;
    string adr;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response;
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Sondages";
        //zones = await AuthService.GetJsonAsync<Sondage[]>(new Uri(adr21));
        //try
        //{
        response = await Http.GetAsync("api/Sondages");
        //response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            //sondages = await JsonSerializer.DeserializeAsync<Sondage[]>(responseContent);
            sondages = JsonConvert.DeserializeObject<Sondage[]>(jsonContent);
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

    private void PrepareForEdit(Sondage sondageedit)
    {
        sondage = sondageedit;
    }
    private void PrepareForDelete(Sondage sondagedelete)
    {
        sondage = sondagedelete;
    }

    private async void DataChanged()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Sondages";
        sondages = await AuthService.GetJsonAsync<Sondage[]>(new Uri(adr21));
        StateHasChanged();
    }

    private async Task Delete()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Sondages/" + sondage.SondageId;
        var task = await AuthService.DeleteJsonAsync(new Uri(adr21));
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "confirmDeleteModal");
        DataChanged();
        sondage = new Sondage();
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
#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52570e6d5e44d078063f4b5f108ba90c240b815b"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Agence
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/creationagence")]
    public partial class CreationAgence : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Création d\'une nouvelle agence</h3>\r\n    </div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                     agence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                                            Creeragence

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "style", "font-size:15px");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "card-body");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.AddMarkupContent(24, "<label for=\"Nom\">Nom :</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "placeholder", "Nom");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                                                                               agence.Libellé

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => agence.Libellé = __value, agence.Libellé))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => agence.Libellé));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "style", "font-size:12px");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __Blazor.ForceT.Client.Pages.Agence.CreationAgence.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line 22 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                                              () => agence.Libellé

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group text-center");
                __builder2.AddMarkupContent(42, "\r\n");
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                 if (wait)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(43, "                    ");
                __builder2.AddMarkupContent(44, "<button type=\"submit\" class=\"btn btn-success\">\r\n                        <span class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                        Ajouter...\r\n                    </button>\r\n");
#nullable restore
#line 32 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "                    ");
                __builder2.AddMarkupContent(46, "<button type=\"submit\" class=\"btn btn-success\">Ajouter</button>\r\n");
#nullable restore
#line 36 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Agence\CreationAgence.razor"
       

    Agence agence = new Agence();
    private bool wait = false;


    private async Task Creeragence()
    {
        //ShowErrors = false;
        wait = true;
        //await Task.Delay(10000);

        //Uri crzone = new Uri("api/Agences");
        //var result = await AuthService.PostJsonAsync<Agence>(crzone,agence);

        //var zoneasjson = JsonSerializer.Serialize(agence);
        string agenceContent = JsonConvert.SerializeObject(agence);
        var response = await Http.PostAsync("api/Agences",new StringContent(agenceContent, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/agence");
            wait = false;
        }
        else
        {
            //    Error = result.Error;
            //    ShowErrors = true;
            response.StatusCode.ToString();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.ForceT.Client.Pages.Agence.CreationAgence
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

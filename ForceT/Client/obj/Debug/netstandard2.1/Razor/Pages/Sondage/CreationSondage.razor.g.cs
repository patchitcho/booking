#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04180c035cae509f82fe4fcf140701c234665bc1"
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
#line 1 "C:\Users\amine\Desktop\project\ForceT\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/creationsondage")]
    public partial class CreationSondage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Création d\'un sondage</h3>\r\n    </div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                     sondage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                             Creersondage

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
                __builder2.AddMarkupContent(24, "<label for=\"Zone\">Libellé du sondage :</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "placeholder", "sondage");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                                                                   sondage.Libellé

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sondage.Libellé = __value, sondage.Libellé))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sondage.Libellé));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "style", "font-size:12px");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __Blazor.ForceT.Client.Pages.Sondage.CreationSondage.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line 22 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                              () => sondage.Libellé

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
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.AddMarkupContent(43, "<label for=\"Ville\">Question :</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "placeholder", "Question");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "ParsingErrorMessage", "Vous devez saisir le poid");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                                                                    sondage.Question

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sondage.Question = __value, sondage.Question))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sondage.Question));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "style", "font-size:12px");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __Blazor.ForceT.Client.Pages.Sondage.CreationSondage.TypeInference.CreateValidationMessage_1(__builder2, 55, 56, 
#nullable restore
#line 29 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                              () => sondage.Question

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.AddMarkupContent(63, "<label for=\"Code\">Type :</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "placeholder", "Type");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                                                                sondage.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sondage.Type = __value, sondage.Type))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sondage.Type));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "style", "font-size:12px");
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __Blazor.ForceT.Client.Pages.Sondage.CreationSondage.TypeInference.CreateValidationMessage_2(__builder2, 74, 75, 
#nullable restore
#line 36 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                              () => sondage.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.AddMarkupContent(82, "<label for=\"Code\">Status :</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "placeholder", "Status");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                                                                  sondage.Statut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sondage.Statut = __value, sondage.Statut))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sondage.Statut));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "style", "font-size:12px");
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __Blazor.ForceT.Client.Pages.Sondage.CreationSondage.TypeInference.CreateValidationMessage_3(__builder2, 93, 94, 
#nullable restore
#line 43 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                              () => sondage.Statut

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.AddMarkupContent(101, "<label>Obligatoire :</label>\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-sm-10");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddMarkupContent(106, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(107);
                __builder2.AddAttribute(108, "id", "checkboxCustom1");
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                                                                         sondage.Obligatoire

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sondage.Obligatoire = __value, sondage.Obligatoire))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => sondage.Obligatoire));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                        ");
                __builder2.AddMarkupContent(113, "<label for=\"checkboxCustom1\">Cette question est obligatoire</label>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                    ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group text-center");
                __builder2.AddMarkupContent(119, "\r\n");
#nullable restore
#line 56 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                         if (wait)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(120, "                            ");
                __builder2.AddMarkupContent(121, "<button type=\"submit\" class=\"btn btn-success\">\r\n                                <span class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                                Ajouter...\r\n                            </button>\r\n");
#nullable restore
#line 62 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                            ");
                __builder2.AddMarkupContent(123, "<button type=\"submit\" class=\"btn btn-success\">Ajouter</button>\r\n");
#nullable restore
#line 66 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(124, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(127, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Sondage\CreationSondage.razor"
       

    Sondage sondage = new Sondage();
    private bool wait = false;


    private async Task Creersondage()
    {
        //ShowErrors = false;
        wait = true;
        //await Task.Delay(10000);

        //Uri crzone = new Uri("api/Sondages");
        //var result = await AuthService.PostJsonAsync<Sondage>(crzone,sondage);

        //var zoneasjson = JsonSerializer.Serialize(sondage);
        string sondageContent = JsonConvert.SerializeObject(sondage);
        var response = await Http.PostAsync("api/Sondages",new StringContent(sondageContent, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/sondage");
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
namespace __Blazor.ForceT.Client.Pages.Sondage.CreationSondage
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

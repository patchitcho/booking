#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efcbb2d58846688f7c9a5029895b94b1eef6b582"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailTourne")]
    public partial class DetailTourne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal fade");
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddAttribute(7, "role", "dialog");
            __builder.AddAttribute(8, "id", "DetailTourne");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(12, "role", "document");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-content");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, @"<div class=""modal-header"">
                    <h5 class=""modal-title"">Detail de la zone</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                  tournee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "style", "font-size:15px");
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "modal-body");
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "card-body");
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n                                    ");
                __builder2.AddMarkupContent(40, "<label for=\"nom\">Libellé de la tournée :</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "placeholder", "Libellé de la tournée");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                                                                     tournee.Libellé

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tournee.Libellé = __value, tournee.Libellé))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tournee.Libellé));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "style", "font-size:12px");
                __builder2.AddMarkupContent(50, "\r\n                                        ");
                __Blazor.ForceT.Client.Pages.Tournée.DetailTourne.TypeInference.CreateValidationMessage_0(__builder2, 51, 52, 
#nullable restore
#line 27 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                  () => tournee.Libellé

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                                    ");
                __builder2.AddMarkupContent(59, "<label for=\"date\">Date prévu :</label>\r\n                                    ");
                __Blazor.ForceT.Client.Pages.Tournée.DetailTourne.TypeInference.CreateInputDate_1(__builder2, 60, 61, "Date de la tournée", 62, "form-control", 63, 
#nullable restore
#line 32 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                                                                  tournee.Date_tournee

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tournee.Date_tournee = __value, tournee.Date_tournee)), 65, () => tournee.Date_tournee);
                __builder2.AddMarkupContent(66, "\r\n                                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "style", "font-size:12px");
                __builder2.AddMarkupContent(69, "\r\n                                        ");
                __Blazor.ForceT.Client.Pages.Tournée.DetailTourne.TypeInference.CreateValidationMessage_2(__builder2, 70, 71, 
#nullable restore
#line 34 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                  () => tournee.Date_tournee

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "\r\n                                    ");
                __builder2.AddMarkupContent(78, "<label for=\"type\">Type :</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "placeholder", "Type");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                                                    tournee.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tournee.Type = __value, tournee.Type))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tournee.Type));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "style", "font-size:12px");
                __builder2.AddMarkupContent(88, "\r\n                                        ");
                __Blazor.ForceT.Client.Pages.Tournée.DetailTourne.TypeInference.CreateValidationMessage_3(__builder2, 89, 90, 
#nullable restore
#line 41 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
                                                                  () => tournee.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(91, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.AddMarkupContent(95, @"<div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                            </div>
                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Tournée\DetailTourne.razor"
       
    [Parameter]
    public Tournee tournee { get; set; }
    [Parameter]
    public Action DataChanged { get; set; }

    private async void HandleValidSubmit()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Tournees/" + tournee.TourneeId;
        var result = await AuthService.PutJsonAsync<Tournee>(new Uri(adr21), tournee);
        await CloseTaskModal();
        DataChanged?.Invoke();
    }
    private async Task CloseTaskModal()
    {
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "DetailTournee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.ForceT.Client.Pages.Tournée.DetailTourne
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
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

#pragma checksum "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6007acb0375a13d03464682c59cba1de518b0782"
// <auto-generated/>
#pragma warning disable 1591
namespace Proxima.Client.Pages.Antcdntspatens
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Pages.Utile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Pages.Utile.Datatable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using BlazorDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Pages.Utile.AutoComplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Proxima.Client.Pages.Utile.RolesUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\amine\Desktop\project\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailAntcdntspatens")]
    public partial class DetailAntcdntspatens : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(8, "id", "DetailZone");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(12, "role", "document");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-content");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, @"<div class=""modal-header"">
                    <h5 class=""modal-title"">Detail de la Antcdntspatens</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                  Antcdntspaten

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "modal-body");
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "card-body");
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.AddMarkupContent(36, "<label for=\"AntcptnCode\">AntcptnCode :</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "placeholder", "AntcptnCode");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                       Antcdntspaten.AntcptnCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.AntcptnCode = __value, Antcdntspaten.AntcptnCode))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Antcdntspaten.AntcptnCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "style", "font-size:12px");
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_0(__builder2, 47, 48, 
#nullable restore
#line 25 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.AntcptnCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.AddMarkupContent(55, "<label for=\"AntcptnLib\">AntcptnLib :</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "placeholder", "AntcptnLib");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                      Antcdntspaten.AntcptnLib

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.AntcptnLib = __value, Antcdntspaten.AntcptnLib))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Antcdntspaten.AntcptnLib));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "style", "font-size:12px");
                __builder2.AddMarkupContent(65, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_1(__builder2, 66, 67, 
#nullable restore
#line 32 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.AntcptnLib

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.AddMarkupContent(74, "<label for=\"AntcptnComnt\">AntcptnComnt :</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "placeholder", "AntcptnComnt");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                        Antcdntspaten.AntcptnComnt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.AntcptnComnt = __value, Antcdntspaten.AntcptnComnt))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Antcdntspaten.AntcptnComnt));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "style", "font-size:12px");
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_2(__builder2, 85, 86, 
#nullable restore
#line 39 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.AntcptnComnt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __builder2.AddMarkupContent(93, "<label for=\"PtienIdf\">PtienIdf :</label>\r\n                                ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateMyInputNumber_3(__builder2, 94, 95, "PtienIdf", 96, "form-control", 97, 
#nullable restore
#line 44 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                        Antcdntspaten.PtienIdf

#line default
#line hidden
#nullable disable
                , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.PtienIdf = __value, Antcdntspaten.PtienIdf)), 99, () => Antcdntspaten.PtienIdf);
                __builder2.AddMarkupContent(100, "\r\n                                ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "style", "font-size:12px");
                __builder2.AddMarkupContent(103, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_4(__builder2, 104, 105, 
#nullable restore
#line 46 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.PtienIdf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(106, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group");
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.AddMarkupContent(112, "<label for=\"AntcdnIdf\">AntcdnIdf :</label>\r\n                                ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateMyInputNumber_5(__builder2, 113, 114, "AntcdnIdf", 115, "form-control", 116, 
#nullable restore
#line 51 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                         Antcdntspaten.AntcdnIdf

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.AntcdnIdf = __value, Antcdntspaten.AntcdnIdf)), 118, () => Antcdntspaten.AntcdnIdf);
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "style", "font-size:12px");
                __builder2.AddMarkupContent(122, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_6(__builder2, 123, 124, 
#nullable restore
#line 53 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.AntcdnIdf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(125, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                            ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-group");
                __builder2.AddMarkupContent(130, "\r\n                                ");
                __builder2.AddMarkupContent(131, "<label for=\"Code\">StartDate :</label>\r\n                                ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateInputDate_7(__builder2, 132, 133, "StartDate", 134, "form-control", 135, 
#nullable restore
#line 58 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                     Antcdntspaten.StartDate

#line default
#line hidden
#nullable disable
                , 136, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.StartDate = __value, Antcdntspaten.StartDate)), 137, () => Antcdntspaten.StartDate);
                __builder2.AddMarkupContent(138, "\r\n                                ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "style", "font-size:12px");
                __builder2.AddMarkupContent(141, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_8(__builder2, 142, 143, 
#nullable restore
#line 60 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.StartDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                            ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "form-group");
                __builder2.AddMarkupContent(149, "\r\n                                ");
                __builder2.AddMarkupContent(150, "<label for=\"EndDate\">EndDate :</label>\r\n                                ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateInputDate_9(__builder2, 151, 152, "EndDate", 153, "form-control", 154, 
#nullable restore
#line 65 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                                                                   Antcdntspaten.EndDate

#line default
#line hidden
#nullable disable
                , 155, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Antcdntspaten.EndDate = __value, Antcdntspaten.EndDate)), 156, () => Antcdntspaten.EndDate);
                __builder2.AddMarkupContent(157, "\r\n                                ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "style", "font-size:12px");
                __builder2.AddMarkupContent(160, "\r\n                                    ");
                __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens.TypeInference.CreateValidationMessage_10(__builder2, 161, 162, 
#nullable restore
#line 67 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
                                                              () => Antcdntspaten.EndDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(163, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n                            ");
                __builder2.AddMarkupContent(167, @"<div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                            </div>
                        
                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(169, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\amine\Desktop\project\Client\Pages\Antcdntspatens\DetailAntcdntspatens.razor"
       
    [Parameter]
    public TabpAntcdntspaten Antcdntspaten { get; set; }
    [Parameter]
    public Action DataChanged { get; set; }

    private async void HandleValidSubmit()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/TabpAntcdntspatens/" + Antcdntspaten.AntcptnIdf;
        var result = await AuthService.PutJsonAsync<TabpAntcdntspaten>(new Uri(adr21), Antcdntspaten);
        await CloseTaskModal();
        DataChanged?.Invoke();
    }
    private async Task CloseTaskModal()
    {
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "DetailAntcdntspatens");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Proxima.Client.Pages.Antcdntspatens.DetailAntcdntspatens
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
        public static void CreateMyInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Proxima.Client.Pages.Utile.MyInputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMyInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Proxima.Client.Pages.Utile.MyInputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
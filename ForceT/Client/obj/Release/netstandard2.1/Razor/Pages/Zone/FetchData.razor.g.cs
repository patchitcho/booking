#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a81a3bd00501c13ce42e2ed6cf2440510f253f"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Zone
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
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
 if (zones == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __Blazor.ForceT.Client.Pages.Zone.FetchData.TypeInference.CreateBlazorDataGrid_0(__builder, 5, 6, 
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                            zones

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 8, "thead-dark", 9, 
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                                                                translate

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 19 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                      true

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 19 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                           PageSelector

#line default
#line hidden
#nullable disable
            , 12, (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __Blazor.ForceT.Client.Pages.Zone.FetchData.TypeInference.CreateDataGridColumn_1(__builder2, 14, 15, 
#nullable restore
#line 21 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                    zones

#line default
#line hidden
#nullable disable
                , 16, "zoneId", 17, 
#nullable restore
#line 21 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                , 18, (__builder3) => {
                    __builder3.AddMarkupContent(19, "<strong>Date</strong>");
                }
                );
                __builder2.AddMarkupContent(20, "\r\n            ");
                __Blazor.ForceT.Client.Pages.Zone.FetchData.TypeInference.CreateDataGridColumn_2(__builder2, 21, 22, 
#nullable restore
#line 22 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                    zones

#line default
#line hidden
#nullable disable
                , 23, "zone", 24, "TemperatureC", 25, 
#nullable restore
#line 22 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __Blazor.ForceT.Client.Pages.Zone.FetchData.TypeInference.CreateDataGridColumn_3(__builder2, 27, 28, 
#nullable restore
#line 23 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                    zones

#line default
#line hidden
#nullable disable
                , 29, "ville", 30, "TemperatureF", 31, 
#nullable restore
#line 23 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.ForceT.Client.Pages.Zone.FetchData.TypeInference.CreateDataGridColumn_4(__builder2, 33, 34, 
#nullable restore
#line 24 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                    zones

#line default
#line hidden
#nullable disable
                , 35, "codepostal", 36, "Summary", 37, 
#nullable restore
#line 24 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
            }
            , 39, (context) => (__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                 context.zoneId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                 context.zone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 29 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                 context.ville

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddContent(51, 
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
                 context.codepostal

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 33 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\FetchData.razor"
       
    Zone[] zones;
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
        }
        else
        {
            adr = response.RequestMessage.ToString();
        }
        //await JSRuntime.InvokeAsync<string>("TestDataTablesAdd", new string[] { "#indexzone" });
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
        {"selector", "lignes par page" }
    };

    private Dictionary<string, int> PageSelector = new Dictionary<string, int>
{
        {"5", 5 },
        {"10", 10 },
        {"20", 20 },
        {"30", 30 },
        {"Tout", 0 }
    };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
namespace __Blazor.ForceT.Client.Pages.Zone.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazorDataGrid_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg7)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.BlazorDataGrid<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ShowTotalResult", __arg1);
        __builder.AddAttribute(__seq2, "TheadClass", __arg2);
        __builder.AddAttribute(__seq3, "Translation", __arg3);
        __builder.AddAttribute(__seq4, "ShowPageSelector", __arg4);
        __builder.AddAttribute(__seq5, "PageSelector", __arg5);
        __builder.AddAttribute(__seq6, "BlazorDataGridColumn", __arg6);
        __builder.AddAttribute(__seq7, "GridRow", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "Filter", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "DropdownFilter", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_3<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_4<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

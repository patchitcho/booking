#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510af863bb350dd483893d0ef6ae86ca2594d4f7"
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
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Liste des zones</h3>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<div>
            <a href=""CreationZone"" style=""font-size:1rem !important;margin-bottom:10px"">
                <i class=""fa fa-plus-circle"" style=""color:#8ab7f6;font-size:16px;margin-right:5px""></i>Créer une nouvelle zone
            </a>
        </div>
");
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
         if (zones == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.Annimation>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 21 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-12");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __Blazor.ForceT.Client.Pages.Zone.IndexZone.TypeInference.CreateBlazorDataGrid_0(__builder, 19, 20, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                            zones

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                    true

#line default
#line hidden
#nullable disable
            , 22, "table table-hover table-bordered table-responsive-xl", 23, "border-width:0.5px", 24, "border:hidden", 25, "thead-light", 26, 
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                      translate

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                                   true

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                                                        PageSelector

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                                                                                10

#line default
#line hidden
#nullable disable
            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                 ExportExcel

#line default
#line hidden
#nullable disable
            ), 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                         CreatePdf

#line default
#line hidden
#nullable disable
            ), 32, (__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Zone.IndexZone.TypeInference.CreateDataGridColumn_1(__builder2, 34, 35, 
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                    zones

#line default
#line hidden
#nullable disable
                , 36, "zoneId", 37, "ZoneID", 38, 
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                , 39, "width:25% ;min-width:120px;border:hidden");
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Zone.IndexZone.TypeInference.CreateDataGridColumn_2(__builder2, 41, 42, 
#nullable restore
#line 31 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                    zones

#line default
#line hidden
#nullable disable
                , 43, "zone", 44, "Zone", 45, 
#nullable restore
#line 31 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                , 46, "width:25% ;min-width:120px;border:hidden");
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Zone.IndexZone.TypeInference.CreateDataGridColumn_3(__builder2, 48, 49, 
#nullable restore
#line 32 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                    zones

#line default
#line hidden
#nullable disable
                , 50, "ville", 51, "Ville", 52, 
#nullable restore
#line 32 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                , 53, "width:25% ;min-width:120px;border:hidden");
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Zone.IndexZone.TypeInference.CreateDataGridColumn_4(__builder2, 55, 56, 
#nullable restore
#line 33 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                    zones

#line default
#line hidden
#nullable disable
                , 57, "codepostal", 58, "Code postale", 59, 
#nullable restore
#line 33 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
                , 60, "width:25% ;min-width:160px;border:hidden");
                __builder2.AddMarkupContent(61, "\r\n                            <th class=\"Fixhead\"></th>\r\n                        ");
            }
            , 62, (context) => (__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __builder2.OpenElement(64, "td");
                __builder2.AddAttribute(65, "style", "padding:0.5rem !important");
                __builder2.AddContent(66, 
#nullable restore
#line 37 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                   context.zoneId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.OpenElement(68, "td");
                __builder2.AddAttribute(69, "style", "padding: 0.5rem !important");
                __builder2.AddContent(70, 
#nullable restore
#line 38 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                    context.zone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "td");
                __builder2.AddAttribute(73, "style", "padding:0.5rem !important");
                __builder2.AddContent(74, 
#nullable restore
#line 39 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                   context.ville

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                            ");
                __builder2.OpenElement(76, "td");
                __builder2.AddAttribute(77, "style", "padding:0.5rem !important");
                __builder2.AddContent(78, 
#nullable restore
#line 40 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                   context.codepostal

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.OpenElement(80, "td");
                __builder2.AddAttribute(81, "class", "Fixcol");
                __builder2.AddMarkupContent(82, "\r\n                                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __builder2.OpenElement(85, "button");
                __builder2.AddAttribute(86, "class", "btn-grid btn-Gridedit");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                    (() => PrepareForEdit(context))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "data-toggle", "modal");
                __builder2.AddAttribute(89, "data-target", "#DetailZone");
                __builder2.AddMarkupContent(90, "\r\n                                        <i class=\"oi oi-document\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                    ");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "class", "btn-grid btn-Gridsup");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                                                   (() => PrepareForDelete(context))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "data-toggle", "modal");
                __builder2.AddAttribute(96, "data-target", "#confirmDeleteModal");
                __builder2.AddMarkupContent(97, "\r\n                                        <i class=\"oi oi-trash\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                        ");
            }
            );
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Zone.DetailZone>(104);
            __builder.AddAttribute(105, "zone", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForceT.Shared.Models.Zone>(
#nullable restore
#line 55 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                             zone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "DataChanged", new System.Action(
#nullable restore
#line 55 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                                DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.ConfirmDialog>(108);
            __builder.AddAttribute(109, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
                                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 57 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Zone\IndexZone.razor"
       

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
namespace __Blazor.ForceT.Client.Pages.Zone.IndexZone
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazorDataGrid_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32> __arg8, int __seq9, global::System.Int32 __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg13)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.BlazorDataGrid<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ShowTotalResult", __arg1);
        __builder.AddAttribute(__seq2, "TableClass", __arg2);
        __builder.AddAttribute(__seq3, "TableStyle", __arg3);
        __builder.AddAttribute(__seq4, "TheadStyle", __arg4);
        __builder.AddAttribute(__seq5, "TheadClass", __arg5);
        __builder.AddAttribute(__seq6, "Translation", __arg6);
        __builder.AddAttribute(__seq7, "ShowPageSelector", __arg7);
        __builder.AddAttribute(__seq8, "PageSelector", __arg8);
        __builder.AddAttribute(__seq9, "PageSize", __arg9);
        __builder.AddAttribute(__seq10, "ExportExcel", __arg10);
        __builder.AddAttribute(__seq11, "CreatePdf", __arg11);
        __builder.AddAttribute(__seq12, "BlazorDataGridColumn", __arg12);
        __builder.AddAttribute(__seq13, "GridRow", __arg13);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ThStyle", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ThStyle", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_3<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ThStyle", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDataGridColumn_4<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.DataGridColumn<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnName", __arg1);
        __builder.AddAttribute(__seq2, "DisplayColumnName", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ThStyle", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

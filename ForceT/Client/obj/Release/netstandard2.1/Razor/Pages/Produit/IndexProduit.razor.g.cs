#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf3aebc32a2399d4aff6100febe81df839dececc"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Produit
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
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produit")]
    public partial class IndexProduit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\" style=\"border-radius:10px\">\r\n        <h3>Liste des produits</h3>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<p>\r\n            <a href=\"CreationProduit\">Créer un nouveau produit</a>\r\n        </p>\r\n");
#nullable restore
#line 17 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
         if (produits == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.Annimation>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 20 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
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
            __Blazor.ForceT.Client.Pages.Produit.IndexProduit.TypeInference.CreateBlazorDataGrid_0(__builder, 19, 20, 
#nullable restore
#line 25 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                            produits

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 25 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            , 22, "table table-hover table-bordered table-responsive-xl", 23, "thead-light", 24, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                           translate

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                                             PageSelector

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                                                                     10

#line default
#line hidden
#nullable disable
            , 28, (__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Produit.IndexProduit.TypeInference.CreateDataGridColumn_1(__builder2, 30, 31, 
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                    produits

#line default
#line hidden
#nullable disable
                , 32, "CodeArticle", 33, "Code Article", 34, 
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                                                true

#line default
#line hidden
#nullable disable
                , 35, "width:33%");
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Produit.IndexProduit.TypeInference.CreateDataGridColumn_2(__builder2, 37, 38, 
#nullable restore
#line 29 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                    produits

#line default
#line hidden
#nullable disable
                , 39, "Designation", 40, "Designation", 41, 
#nullable restore
#line 29 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                                               true

#line default
#line hidden
#nullable disable
                , 42, "width:33%");
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __Blazor.ForceT.Client.Pages.Produit.IndexProduit.TypeInference.CreateDataGridColumn_3(__builder2, 44, 45, 
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                    produits

#line default
#line hidden
#nullable disable
                , 46, "Prix", 47, "Prix", 48, 
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
                , 49, "width:33%");
                __builder2.AddMarkupContent(50, "\r\n                        ");
            }
            , 51, (context) => (__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#nullable restore
#line 33 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                 context.CodeArticle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.OpenElement(56, "td");
                __builder2.AddContent(57, 
#nullable restore
#line 34 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                 context.Designation

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.OpenElement(59, "td");
                __builder2.AddContent(60, 
#nullable restore
#line 35 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                 context.Prix

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "td");
                __builder2.AddAttribute(63, "style", "min-width:80px ;max-width:80px ;padding:0.5rem !important");
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "style", "align-content:center");
                __builder2.AddMarkupContent(67, "\r\n                                    ");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "class", "btn-grid btn-Gridedit");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                    (() => PrepareForEdit(context))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "data-toggle", "modal");
                __builder2.AddAttribute(72, "data-target", "#DetailProduit");
                __builder2.AddMarkupContent(73, "\r\n                                        <i class=\"oi oi-document\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                    ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "class", "btn-grid btn-Gridsup");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                                                   (() => PrepareForDelete(context))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "data-toggle", "modal");
                __builder2.AddAttribute(79, "data-target", "#confirmDeleteModal");
                __builder2.AddMarkupContent(80, "\r\n                                        <i class=\"oi oi-trash\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                        ");
            }
            );
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Produit.DetailProduit>(87);
            __builder.AddAttribute(88, "produit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForceT.Shared.Models.Produit>(
#nullable restore
#line 50 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                    produit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "DataChanged", new System.Action(
#nullable restore
#line 50 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                                           DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenComponent<ForceT.Client.Pages.Utile.ConfirmDialog>(91);
            __builder.AddAttribute(92, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
                                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 52 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Produit\IndexProduit.razor"
       

    Produit[] produits;
    Produit produit = new Produit();
    private bool hidden = false;
    string adr;
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

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response;
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Produits";
        //adresses = await AuthService.GetJsonAsync<Adresse[]>(new Uri(adr21));
        //try
        //{
        response = await Http.GetAsync("api/Produits");
        //response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            adr = response.StatusCode.ToString();
            //adresses = await JsonSerializer.DeserializeAsync<Adresse[]>(responseContent);
            produits = JsonConvert.DeserializeObject<Produit[]>(jsonContent);
        }
        else
        {
            Console.WriteLine(response.StatusCode);
        }
    }

    private void PrepareForEdit(Produit produitedit)
    {
        produit = produitedit;
    }

    private void PrepareForDelete(Produit produitdelete)
    {
        produit = produitdelete;
    }

    private async void DataChanged()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Produits";
        produits = await AuthService.GetJsonAsync<Produit[]>(new Uri(adr21));
        StateHasChanged();
    }

    private async Task Delete()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Produits/" + produit.ProduitId;
        var task = await AuthService.DeleteJsonAsync(new Uri(adr21));
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "confirmDeleteModal");
        DataChanged();
        produit = new Produit();
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
namespace __Blazor.ForceT.Client.Pages.Produit.IndexProduit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazorDataGrid_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32> __arg6, int __seq7, global::System.Int32 __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg9)
        {
        __builder.OpenComponent<global::ForceT.Client.Pages.Utile.Datatable.BlazorDataGrid<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ShowTotalResult", __arg1);
        __builder.AddAttribute(__seq2, "TableClass", __arg2);
        __builder.AddAttribute(__seq3, "TheadClass", __arg3);
        __builder.AddAttribute(__seq4, "Translation", __arg4);
        __builder.AddAttribute(__seq5, "ShowPageSelector", __arg5);
        __builder.AddAttribute(__seq6, "PageSelector", __arg6);
        __builder.AddAttribute(__seq7, "PageSize", __arg7);
        __builder.AddAttribute(__seq8, "BlazorDataGridColumn", __arg8);
        __builder.AddAttribute(__seq9, "GridRow", __arg9);
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
    }
}
#pragma warning restore 1591
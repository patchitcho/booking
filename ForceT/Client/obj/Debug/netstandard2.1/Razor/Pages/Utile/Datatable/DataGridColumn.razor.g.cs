#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea394908af088476fca46e6f32f57a4046af8462"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Utile.Datatable
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
#line 4 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
using BlazorDataGrid.Services;

#line default
#line hidden
#nullable disable
    public partial class DataGridColumn<TItem> : BlazorGridColumnBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "th");
            __builder.AddAttribute(1, "style", (
#nullable restore
#line 8 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
            ThStyle

#line default
#line hidden
#nullable disable
            ) + " ;vertical-align:" + " top;");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
         if (ChildContent != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "            ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "class", "hov");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                          () => SortTable(ColumnName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, 
#nullable restore
#line 11 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 12 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "hov");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                          () => SortTable(ColumnName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, 
#nullable restore
#line 15 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                         DisplayColumnName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "style", "color: #33b35a;cursor: pointer;float: right");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                            (() => search(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "style", "color:coral;float:right");
            __builder.OpenElement(23, "i");
            __builder.AddAttribute(24, "class", "oi" + " " + (
#nullable restore
#line 18 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                             GetSortStyle(ColumnName)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
         if (Filter && !DropdownFilter)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
             if (Showsearchinput)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "input-group");
            __builder.AddAttribute(29, "style", "min-width:200px;width:auto");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "placeholder", "Recherche...");
            __builder.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                                                   (e) => OnInput(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn");
            __builder.AddAttribute(39, "style", "margin-left: -40px; z-index: 100;");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                                            (() => search(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.AddMarkupContent(42, "<div style=\"color:red\">\r\n                            ✕\r\n                        </div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 49 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "    \r\n");
#nullable restore
#line 52 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
     if (DropdownFilter)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "input-group mb-3");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "select");
            __builder.AddAttribute(51, "class", "custom-select");
            __builder.AddAttribute(52, "id", "inputGroupSelect01");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                                                          SelectedDropdownFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedDropdownFilter = __value, SelectedDropdownFilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "selected", true);
            __builder.AddAttribute(58, "value", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 57 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                 foreach (var item in CreateFilterList())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                    ");
            __builder.OpenElement(61, "option");
            __builder.AddAttribute(62, "value", 
#nullable restore
#line 59 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                    item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(63, 
#nullable restore
#line 59 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                                           item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 60 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 63 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\Utile\Datatable\DataGridColumn.razor"
       
    [Parameter]
    public string ThStyle { get; set; }

    [Parameter]
    public string ColumnName { get; set; }
    [Parameter]
    public string DisplayColumnName { get; set; } = string.Empty;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Filter { get; set; } = false;

    [Parameter]
    public bool DropdownFilter { get; set; } = false;

    [CascadingParameter]
    BlazorDataGrid<TItem> BlazorDataTable { get; set; }

    private bool IsSortedAscending;

    protected int DebounceMilliseconds { get; set; } = 800;

    [Parameter]
    public IEnumerable<TItem> Items { get; set; }

    private string PreviousValue { get; set; } = string.Empty;

    private bool Showsearchinput = false;

    private string _selectedDropdownFilter;
    protected string SelectedDropdownFilter
    {
        get => _selectedDropdownFilter;
        set
        {
            _selectedDropdownFilter = value;
            Filtering(value, ColumnName, true);
        }
    }

    private void SortTable(string columnName)
    {
        if (columnName != BlazorDataTable.CurrentSortColumn)
        {
            BlazorDataTable.CurrentSortColumn = columnName;
            IsSortedAscending = true;
            BlazorDataTable.ChangeSorting = true;
            AppState.CallRequestRefresh();

        }
        else
        {
            BlazorDataTable.ChangeSorting = true;
            AppState.CallRequestRefresh();
            IsSortedAscending = !IsSortedAscending;
        }
    }

    private string GetSortStyle(string columnName)
    {
        if (BlazorDataTable.CurrentSortColumn != columnName)
        {
            return string.Empty;
        }
        if (IsSortedAscending)
        {
            return "oi-arrow-thick-top";
        }
        else
        {
            return "oi-arrow-thick-bottom";
        }
    }

    private void Filtering(string value, string columnName, bool fromlist = false)
    {
        BlazorDataTable.FilterDictionary[columnName] = value;

        if (fromlist || value.Length < PreviousValue.Length)
        {
            BlazorDataTable.Items = Items;
        }

        AppState.CallRequestRefresh();
        PreviousValue = value;
    }

    private List<string> CreateFilterList()
    {
        List<string> filterList = new List<string>();

        var properties = typeof(TItem).GetProperties();
        foreach (var item in Items)
        {
            foreach (var property in properties)
            {
                if (string.Equals(property.Name, ColumnName, StringComparison.OrdinalIgnoreCase))
                {
                    if (!filterList.Any(x => x == property.GetValue(item, null).ToString()))
                    {
                        filterList.Add(property.GetValue(item, null).ToString());
                    }
                }
            }
        }
        filterList.Sort();
        return filterList;
    }

    private void OnInput(ChangeEventArgs eventArgs)
    {
        var filterValue = ((ChangeEventArgs)eventArgs).Value?.ToString();
        Debounce(eventArgs, DebounceMilliseconds, async (e) =>
        {
            await InvokeAsync(async () =>
            {
                await Task.Delay(1);
                Filtering(filterValue, ColumnName);
            }).ConfigureAwait(false);

        });

    }

    private void search(bool show)
    {
        Showsearchinput = show;
        Filtering("", ColumnName);
        Console.WriteLine("ok");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591

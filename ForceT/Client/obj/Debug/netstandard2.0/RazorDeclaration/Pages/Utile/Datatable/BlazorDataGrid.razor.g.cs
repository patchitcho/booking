#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utile\Datatable\BlazorDataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fdf8aabc040333d136b75062915e3d0eb5a7631"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ForceT.Client.Pages.Utile.Datatable
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
using ForceT.Client.Services.Pdf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using PdfSharpCore.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using PdfSharpCore.Fonts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using PdfSharpCore.Pdf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utile\Datatable\BlazorDataGrid.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utile\Datatable\BlazorDataGrid.razor"
using BlazorDataGrid.Services;

#line default
#line hidden
#nullable disable
    public partial class BlazorDataGrid<TableItem> : BlazorDataGridBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utile\Datatable\BlazorDataGrid.razor"
       
    const int defaultPagerSize = 10;
    int totalPages;
    int curPage;
    int pagerSize;

    int startPage;
    int endPage;

    int initCount;

    public string CurrentSortColumn = string.Empty;
    public string LastSortedColumn = string.Empty;
    public bool IsSortedAscending;
    public bool ChangeSorting = false;

    private int _pageSize = -1;
    [Parameter]
    public int PageSize
    {
        get => _pageSize;
        set
        {
            _pageSize = value;
            curPage = 1;
            startPage = 1;
            if (value == 0)
            {
                ItemList = Items;
                totalPages = 1;
                pagerSize = 1;
            }
            else
            {
                ItemList = Items.Skip((curPage - 1) * PageSize).Take(PageSize);
                totalPages = (int)Math.Ceiling(Items.Count() / (decimal)PageSize);
                pagerSize = 5;
            }


            StateHasChanged();
            updateList(curPage);
            SetPagerSize("filtre");
        }
    }

    public int ItemPerPage { get; set; }


    [Parameter]
    public RenderFragment BlazorDataGridColumn { get; set; }


    [Parameter]
    public RenderFragment<TableItem> GridRow { get; set; }

    [Parameter]
    public IEnumerable<TableItem> Items { get; set; }

    [Parameter]
    public bool ShowTotalResult { get; set; } = false;

    [Parameter]
    public RenderFragment OtherContent { get; set; }

    [Parameter]
    public string TableClass { get; set; } = "table table-striped table-bordered mdl-data-table";

    [Parameter]
    public string TheadClass { get; set; } = "thead-inverse";

    [Parameter]
    public string TbodyClass { get; set; }

    [Parameter]
    public string TableStyle { get; set; }

    [Parameter]
    public string TheadStyle { get; set; }

    [Parameter]
    public string TbodyStyle { get; set; }

    [Parameter]
    public Dictionary<string, string> Translation { get; set; }

    #region Translation
    string OriginalPages { get; set; }
    string OriginalTotalResult { get; set; }
    string OriginalTotalResultPlural { get; set; }
    string OriginalFilteredResults { get; set; }
    string OriginalFilteredResultsPlural { get; set; }

    private bool NeedUpdate { get; set; } = false;
    #endregion


    IEnumerable<TableItem> ItemList { get; set; }

    public Dictionary<string, string> FilterDictionary { get; set; }

    public bool loadingRow { get; set; } = false;

    protected override void OnInitialized()
    {
        pagerSize = defaultPagerSize;
        initCount = Items.Count();
        if (ShowPageSelector)
        {
            if (PageSizeList == null)
            {
                if (PageSelector != null)
                {
                    PageSizeList = new List<PageSizeStruct>();
                    foreach (var selector in PageSelector)
                    {
                        PageSizeList.Add(new PageSizeStruct() { Label = selector.Key, Value = selector.Value });
                    }
                }
                else
                {
                    PageSizeList = new List<PageSizeStruct>
                {
                        new PageSizeStruct() {Label = "5", Value = 5},
                        new PageSizeStruct() {Label = "10", Value = 10},
                        new PageSizeStruct() {Label = "25", Value = 25},
                        new PageSizeStruct() {Label = "50", Value = 50},
                        new PageSizeStruct() {Label = "100", Value = 100},
                        new PageSizeStruct() {Label = "*", Value = 0},
                    };
                }
            }
            try
            {
                if (PageSize == -1)
                    PageSize = PageSizeList[0].Value;
            }
            catch (Exception)
            {
                PageSize = 5;
            }

        }

        curPage = 1;

        AppState.RefreshRequested += RefreshMe;

        FilterDictionary = new Dictionary<string, string>();

        InitTranslationDictionnary();
        NeedUpdate = true;
        UpdateTranslationDictionnary();
    }

    private void RefreshMe()
    {
        StateHasChanged();
        curPage = 1;
        updateList(curPage);
        SetPagerSize("filtre");
    }

    public void updateList(int currentPage)
    {
        LoadData();

        if (PageSize == 0)
        {
            ItemList = Items;
            totalPages = 1;
        }
        else
        {
            ItemList = Items.Skip((currentPage - 1) * PageSize).Take(PageSize);
            totalPages = (int)Math.Ceiling(Items.Count() / (decimal)PageSize);
        }
        curPage = currentPage;

        if (NeedUpdate)
        {
            UpdateTranslationDictionnary();
        }
        this.StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        if (direction == "filtre")
        {
            startPage = 1;
            pagerSize = defaultPagerSize;
            if (pagerSize > totalPages)
            {
                pagerSize = totalPages;
            }
            endPage = pagerSize;
            if (endPage > totalPages)
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
    }

    public void NavigateToPage(Direction direction)
    {
        switch (direction)
        {
            case Direction.First:
                break;
            case Direction.Previous:
                if (curPage > 1 && curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage--;
                break;
            case Direction.Next:
                if (curPage < totalPages && curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage++;
                break;
            case Direction.PreviousSegment:
                SetPagerSize("back");
                curPage = endPage;
                break;
            case Direction.NextSegment:
                SetPagerSize("forward");
                curPage = startPage;
                break;
            case Direction.Last:
                break;
            default:
                break;
        }
        updateList(curPage);
        UpdateTranslationDictionnary();
    }

    private void InitTranslationDictionnary()
    {
        if (Translation is null)
        {
            Translation = new Dictionary<string, string>();
            Translation.Add("previous", "Prec.");
            Translation.Add("next", "Suiv.");
            Translation.Add("pages", $"Page {curPage} de {totalPages}");
            OriginalPages = "Page __curpage__ de __totalpages__";
            Translation.Add("totalresult", $"{Items.Count().ToString()} enregistrement");
            Translation.Add("totalresultplural", $"{Items.Count().ToString()} enregistrements");
            OriginalTotalResult = "__totalcount__ enregistrement";
            OriginalTotalResultPlural = "__totalcount__ enregistrements";

            Translation.Add("filteredresults", $"{@Items.Count()} résultat sur {@initCount} enregistrements");
            OriginalFilteredResults = "__filteredcount__ résultat sur __totalcount__ enregistrements";
            Translation.Add("filteredresultsplural", $"{@Items.Count()} résultats sur {@initCount} enregistrements");
            OriginalFilteredResultsPlural = "__filteredcount__ résultats sur __totalcount__ enregistrements";

            Translation.Add("selector", "Résultats par page");
            Translation.Add("loading", "Chargement ...");

        }
        else
        {
            try
            {
                if (!Translation.ContainsKey("previous"))
                {
                    Translation.Add("previous", "Prec.");
                }
                if (!Translation.ContainsKey("next"))
                {
                    Translation.Add("next", "Suiv.");
                }
                if (!Translation.ContainsKey("pages"))
                {
                    Translation.Add("pages", $"Page {curPage} de {totalPages}");
                    OriginalPages = "Page __curpage__ de __totalpages__";
                }
                else
                {
                    OriginalPages = Translation["pages"];
                }

                if (!Translation.ContainsKey("totalresult"))
                {
                    Translation.Add("totalresult", $"{Items.Count().ToString()} enregistrement");
                    OriginalTotalResult = "__totalcount__ enregistrement";
                }
                else
                {
                    OriginalTotalResult = Translation["totalresult"];
                }

                if (!Translation.ContainsKey("totalresultplural"))
                {
                    Translation.Add("totalresultplural", $"{Items.Count().ToString()} enregistrements");
                    OriginalTotalResultPlural = "__totalcount__ enregistrements";
                }
                else
                {
                    OriginalTotalResultPlural = Translation["totalresultplural"];
                }

                if (!Translation.ContainsKey("filteredresults"))
                {
                    Translation.Add("filteredresults", $"{Items.Count()} résultat sur {initCount} enregistrements");
                    OriginalFilteredResults = "__filteredcount__ résultat sur __totalcount__ enregistrements";
                }
                else
                {
                    OriginalFilteredResults = Translation["filteredresults"];
                }

                if (!Translation.ContainsKey("filteredresultsplural"))
                {
                    Translation.Add("filteredresultsplural", $"{Items.Count()} résultats sur {initCount} enregistrements");
                    OriginalFilteredResultsPlural = "__filteredcount__ résultats sur __totalcount__ enregistrements";
                }
                else
                {
                    OriginalFilteredResultsPlural = Translation["filteredresultsplural"];
                }

                if (!Translation.ContainsKey("selector"))
                {
                    Translation.Add("selector", "Résultats par page : ");
                }

                if (!Translation.ContainsKey("loading"))
                {
                    Translation.Add("loading", "Chargement ...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private void UpdateTranslationDictionnary()
    {
        try
        {
            if (Translation != null)
            {
                Translation["pages"] = OriginalPages?.Replace("__curpage__", curPage.ToString())
                                                    .Replace("__totalpages__", totalPages.ToString());

                Translation["totalresult"] = OriginalTotalResult?.Replace("__totalcount__", Items?.Count().ToString());

                Translation["totalresultplural"] = OriginalTotalResultPlural?.Replace("__totalcount__", Items?.Count().ToString());

                Translation["filteredresults"] = OriginalFilteredResults?.Replace("__filteredcount__", Items?.Count().ToString())
                                                              .Replace("__totalcount__", initCount.ToString());

                Translation["filteredresultsplural"] = OriginalFilteredResultsPlural?.Replace("__filteredcount__", Items?.Count().ToString())
                                                                    .Replace("__totalcount__", initCount.ToString());
            }
        }
        catch (System.NullReferenceException nre)
        {
            Console.WriteLine(nre.Message);
        }
    }

    private void LoadData()
    {
        loadingRow = true;
        StateHasChanged();

        if (FilterDictionary != null)
        {
            foreach (var column in FilterDictionary)
            {
                Items = Items.Where(x => x.GetType().GetProperty(column.Key).GetValue(x, null).ToString().IndexOf(column.Value, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
        }

        if (!string.IsNullOrEmpty(CurrentSortColumn))
        {
            if (!string.Equals(CurrentSortColumn, LastSortedColumn, StringComparison.OrdinalIgnoreCase))
            {
                Items = Items.OrderBy(x => x.GetType().GetProperty(CurrentSortColumn).GetValue(x, null)).ToList();
                LastSortedColumn = CurrentSortColumn;
                IsSortedAscending = true;
            }
            else
            {
                if (ChangeSorting)
                {
                    if (IsSortedAscending)
                    {
                        Items = Items.OrderByDescending(x => x.GetType().GetProperty(CurrentSortColumn).GetValue(x, null)).ToList();
                    }
                    else
                    {
                        Items = Items.OrderBy(x => x.GetType().GetProperty(CurrentSortColumn).GetValue(x, null)).ToList();
                    }
                    IsSortedAscending = !IsSortedAscending;
                    ChangeSorting = false;
                }
                else
                {
                    if (IsSortedAscending)
                    {
                        Items = Items.OrderBy(x => x.GetType().GetProperty(CurrentSortColumn).GetValue(x, null)).ToList();
                    }
                    else
                    {
                        Items = Items.OrderByDescending(x => x.GetType().GetProperty(CurrentSortColumn).GetValue(x, null)).ToList();
                    }
                }
            }
        }

        loadingRow = false;
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591

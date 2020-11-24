#pragma checksum "C:\Users\amine\Desktop\project\ForceT\Client\Pages\EntréeStock\CreationEntStock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e836b900e6f6a888e0fd9488d35241ff932c335a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ForceT.Client.Pages.EntréeStock
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/creationentstock")]
    public partial class CreationEntStock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\amine\Desktop\project\ForceT\Client\Pages\EntréeStock\CreationEntStock.razor"
       
    string Error;
    bool ShowErrors = false;
    Adresse adr = new Adresse();
    List<Produit> produits;
    Produit produit = new Produit();
    private bool wait = false;
    bool show = false;
    Pan pan = new Pan();
    List<Pan> pans = new List<Pan>();
    List<JournalStock> EntJls = new List<JournalStock>();
    JournalStock EntJl = new JournalStock();

    protected override async Task OnInitializedAsync()
    {
        await GetProduit();
    }

    private async Task<List<Produit>> GetProduit()
    {
        HttpResponseMessage response;
        response = await Http.GetAsync("api/Produits");
        if (response.IsSuccessStatusCode)
        {
            string jsonContent = response.Content.ReadAsStringAsync().Result;
            produits = JsonConvert.DeserializeObject<List<Produit>>(jsonContent);
        }
        else
        {
            Console.WriteLine(response.StatusCode);
        }
        return produits;
    }

    private async Task<IEnumerable<Produit>> SearchCode(string searchText)
    {
        if (produits == null)
        {
            await GetProduit();
        }
        return await Task.FromResult(produits.Where(x => x.CodeArticle.ToLower().Contains(searchText.ToLower())).ToList());

    }

    private async Task<IEnumerable<Produit>> SearchDesignation(string searchText)
    {
        if (produits == null)
        {
            await GetProduit();
        }
        return await Task.FromResult(produits.Where(x => x.Designation.ToLower().Contains(searchText.ToLower())).ToList());
        //|| x.Author.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task Addent()
    {
       
    }

    private async Task Addrow()
    {
        if (EntJl.produit == null || EntJl.produit.Designation == null || EntJl.Qte == 0) return;
        if (EntJls.Exists(x => x.produit == EntJl.produit))
        {
            Error = "Vous avez déja ajouté ce produit";
            ShowErrors = true;
            await Task.Delay(5000);
            ShowErrors = false;
            return;
        }
        EntJls.Add(new JournalStock { produit = EntJl.produit, Qte = EntJl.Qte});
    }

    private async Task Removerow(JournalStock entjl)
    {
        EntJls.Remove(entjl);
    }

    public class Pan
    {
        public Produit Prod { get; set; }
        public int Qte { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\amine\Desktop\project\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b72c046c47287505c3f570a76541e1c55ce3984"
// <auto-generated/>
#pragma warning disable 1591
namespace Proxima.Client.Shared
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "nav");
                __builder2.AddAttribute(4, "class", "navbar");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container-fluid");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "navbar-holder d-flex align-items-center justify-content-between");
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.AddMarkupContent(12, @"<div class=""navbar-header"">
                        <a id=""toggle-btn"" class=""menu-btn"" onclick=""toggleSidBar()""><i class=""icon-bars""> </i></a><a href class=""navbar-brand"">
                            <div class=""brand-text d-none d-md-inline-block""><span>Force </span><strong class=""text-primary"">TRACKING</strong></div>
                        </a>
                    </div>
                    ");
                __builder2.OpenElement(13, "ul");
                __builder2.AddAttribute(14, "class", "nav-menu list-unstyled d-flex flex-md-row align-items-md-center");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "li");
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "a");
                __builder2.AddAttribute(19, "style", "color:white");
                __builder2.AddContent(20, "Hello, ");
                __builder2.AddContent(21, 
#nullable restore
#line 16 "C:\Users\amine\Desktop\project\Client\Shared\LoginDisplay.razor"
                                                           context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(22, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "id", "Deco");
                __builder2.AddAttribute(26, "type", "submit");
                __builder2.AddAttribute(27, "class", "btn btn-link");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\amine\Desktop\project\Client\Shared\LoginDisplay.razor"
                                                                                           Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(29, "<span class=\"Deco\">Deconexion  </span><i id=\"Decoico\" class=\"fa fa-sign-out\" style=\"margin-left:5px\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\amine\Desktop\project\Client\Shared\LoginDisplay.razor"
      
    private async Task Logout()
    {
        await AuthService.Logout();
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981c08cf332faa5477bde74cbd49e598199ec48c"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Shared
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
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using ForceT.Client.Pages.Utile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"side-navbar\" id=\"sid\">\r\n    <div class=\"side-navbar-wrapper\">\r\n        \r\n        <div class=\"sidenav-header d-flex align-items-center justify-content-center\">\r\n            \r\n            <div class=\"sidenav-header-inner text-center\">\r\n                <h2 class=\"h5\">Nathan Andrews</h2><span>Web Developer</span>\r\n            </div>\r\n            \r\n            <div class=\"sidenav-header-logo\"><a class=\"brand-small text-center\"> <strong>F</strong><strong class=\"text-primary\">T</strong></a></div>\r\n        </div>\r\n        \r\n        <div id=\"sid\">\r\n            <div class=\"main-menu\">\r\n                <h5 class=\"sidenav-heading\">Main</h5>\r\n                <ul id=\"side-main-menu\" class=\"side-menu list-unstyled\">\r\n                    <li><a href Match=\"NavLinkMatch.All\"> <i class=\"icon-home\"></i>Home</a></li>\r\n                    <li><a href=\"counter\"> <i class=\"icon-form\"></i>counter</a></li>\r\n                    <li><a href=\"fetchdata\"> <i class=\"fa fa-bar-chart\"></i>fetchdata</a></li>\r\n                    <li><a href=\"zone\"> <i class=\"icon-grid\"></i>Zone</a></li>\r\n                    <li>\r\n                        <a href=\"#exampledropdownDropdown\" aria-expanded=\"false\" data-toggle=\"collapse\" onclick=\"toggleNavBar()\"> <i class=\"icon-interface-windows\"></i>Example dropdown </a>\r\n                        <ul id=\"exampledropdownDropdown\" class=\"collapse list-unstyled \">\r\n                            <li><a href=\"#\">Page</a></li>\r\n                            <li><a href=\"#\">Page</a></li>\r\n                            <li><a href=\"#\">Page</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li><a href=\"login.html\"> <i class=\"icon-interface-windows\"></i>Login page</a></li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"icon-mail\"></i>Demo<div class=\"badge badge-warning\">6 New</div>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"admin-menu\">\r\n                <h5 class=\"sidenav-heading\">Second menu</h5>\r\n                <ul id=\"side-admin-menu\" class=\"side-menu list-unstyled\">\r\n                    <li> <a href=\"#\"> <i class=\"icon-screen\"> </i>Demo</a></li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"icon-flask\"> </i>Demo\r\n                            <div class=\"badge badge-info\">Special</div>\r\n                        </a>\r\n                    </li>\r\n                    <li> <a href> <i class=\"icon-flask\"> </i>Demo</a></li>\r\n                    <li> <a href> <i class=\"icon-picture\"> </i>Demo</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</nav>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

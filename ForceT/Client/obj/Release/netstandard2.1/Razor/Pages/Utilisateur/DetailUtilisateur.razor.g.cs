#pragma checksum "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d62ae408830f0062bd61e4642038dc32da7e6d4"
// <auto-generated/>
#pragma warning disable 1591
namespace ForceT.Client.Pages.Utilisateur
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailUtilisateur")]
    public partial class DetailUtilisateur : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "border-radius:10px");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal fade");
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddAttribute(7, "role", "dialog");
            __builder.AddAttribute(8, "id", "DetailAdresse");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(12, "role", "document");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-content");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, @"<div class=""modal-header"">
                        <h5 class=""modal-title"">Detail d'utilisateur</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                      UpdUserModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "style", "font-size:15px");
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                            ");
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
                __builder2.AddAttribute(38, "class", "col-lg-3 col-md-3");
                __builder2.AddMarkupContent(39, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(40);
                __builder2.AddAttribute(41, "title", "Véhicule");
                __builder2.AddAttribute(42, "ID", "id1");
                __builder2.AddAttribute(43, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(45);
                    __builder3.AddAttribute(46, "label", "Création de véhicule");
                    __builder3.AddAttribute(47, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                     UpdUserModel.Roles.VehiculeCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(49);
                    __builder3.AddAttribute(50, "label", "Liste des véhicules");
                    __builder3.AddAttribute(51, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                    UpdUserModel.Roles.VehiculeRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(53);
                    __builder3.AddAttribute(54, "label", "Modification de véhicule");
                    __builder3.AddAttribute(55, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                         UpdUserModel.Roles.VehiculeUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(57);
                    __builder3.AddAttribute(58, "label", "Suppression de véhicule");
                    __builder3.AddAttribute(59, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                        UpdUserModel.Roles.VehiculeDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(62);
                __builder2.AddAttribute(63, "title", "Adresse");
                __builder2.AddAttribute(64, "ID", "id2");
                __builder2.AddAttribute(65, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(67);
                    __builder3.AddAttribute(68, "label", "Création d\'adresse");
                    __builder3.AddAttribute(69, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                   UpdUserModel.Roles.AdresseCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(71);
                    __builder3.AddAttribute(72, "label", "Liste des adresse");
                    __builder3.AddAttribute(73, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                  UpdUserModel.Roles.AdresseRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(75);
                    __builder3.AddAttribute(76, "label", "Modification d\'adresse");
                    __builder3.AddAttribute(77, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                       UpdUserModel.Roles.AdresseUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(79);
                    __builder3.AddAttribute(80, "label", "Suppression d\'adresse");
                    __builder3.AddAttribute(81, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                      UpdUserModel.Roles.AdresseDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-lg-3 col-md-3");
                __builder2.AddMarkupContent(87, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(88);
                __builder2.AddAttribute(89, "title", "Sondage");
                __builder2.AddAttribute(90, "ID", "id3");
                __builder2.AddAttribute(91, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(92, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(93);
                    __builder3.AddAttribute(94, "label", "Création de sondage");
                    __builder3.AddAttribute(95, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                    UpdUserModel.Roles.SondageCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(97);
                    __builder3.AddAttribute(98, "label", "Liste des sondages");
                    __builder3.AddAttribute(99, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                   UpdUserModel.Roles.SondageRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(101);
                    __builder3.AddAttribute(102, "label", "Modification de sondage");
                    __builder3.AddAttribute(103, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                        UpdUserModel.Roles.SondageUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(105);
                    __builder3.AddAttribute(106, "label", "Suppression de sondage");
                    __builder3.AddAttribute(107, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                       UpdUserModel.Roles.SondageDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(110);
                __builder2.AddAttribute(111, "title", "Course");
                __builder2.AddAttribute(112, "ID", "id4");
                __builder2.AddAttribute(113, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(114, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(115);
                    __builder3.AddAttribute(116, "label", "Création de course");
                    __builder3.AddAttribute(117, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                   UpdUserModel.Roles.CourseCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(119);
                    __builder3.AddAttribute(120, "label", "Liste des courses");
                    __builder3.AddAttribute(121, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                  UpdUserModel.Roles.CourseRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(122, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(123);
                    __builder3.AddAttribute(124, "label", "Modification de course");
                    __builder3.AddAttribute(125, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                       UpdUserModel.Roles.CourseUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(126, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(127);
                    __builder3.AddAttribute(128, "label", "Suppression de course");
                    __builder3.AddAttribute(129, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                      UpdUserModel.Roles.CourseDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "col-lg-3 col-md-3");
                __builder2.AddMarkupContent(135, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(136);
                __builder2.AddAttribute(137, "title", "Zone");
                __builder2.AddAttribute(138, "ID", "id5");
                __builder2.AddAttribute(139, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(140, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(141);
                    __builder3.AddAttribute(142, "label", "Création de zone");
                    __builder3.AddAttribute(143, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                 UpdUserModel.Roles.ZoneCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(145);
                    __builder3.AddAttribute(146, "label", "Liste des zones");
                    __builder3.AddAttribute(147, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                UpdUserModel.Roles.ZoneRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(148, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(149);
                    __builder3.AddAttribute(150, "label", "Modification de zone");
                    __builder3.AddAttribute(151, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                     UpdUserModel.Roles.ZoneUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(152, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(153);
                    __builder3.AddAttribute(154, "label", "Suppression de zone");
                    __builder3.AddAttribute(155, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 65 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                    UpdUserModel.Roles.ZoneDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(156, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(157, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(158);
                __builder2.AddAttribute(159, "title", "Tournée");
                __builder2.AddAttribute(160, "ID", "id6");
                __builder2.AddAttribute(161, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(162, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(163);
                    __builder3.AddAttribute(164, "label", "Création de tournée");
                    __builder3.AddAttribute(165, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                    UpdUserModel.Roles.TourneeCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(166, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(167);
                    __builder3.AddAttribute(168, "label", "Liste des tournées");
                    __builder3.AddAttribute(169, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                   UpdUserModel.Roles.TourneeRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(171);
                    __builder3.AddAttribute(172, "label", "Modification de tournée");
                    __builder3.AddAttribute(173, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                        UpdUserModel.Roles.TourneeUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(175);
                    __builder3.AddAttribute(176, "label", "Suppression de tournée");
                    __builder3.AddAttribute(177, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                       UpdUserModel.Roles.TourneeDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(178, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(179, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n                                ");
                __builder2.OpenElement(181, "div");
                __builder2.AddAttribute(182, "class", "col-lg-3 col-md-3");
                __builder2.AddMarkupContent(183, "\r\n                                    ");
                __builder2.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Roles>(184);
                __builder2.AddAttribute(185, "title", "Agence");
                __builder2.AddAttribute(186, "ID", "id7");
                __builder2.AddAttribute(187, "roles", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(188, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(189);
                    __builder3.AddAttribute(190, "label", "Création d\'agence");
                    __builder3.AddAttribute(191, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                  UpdUserModel.Roles.AgenceCreat

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(192, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(193);
                    __builder3.AddAttribute(194, "label", "Liste des agences");
                    __builder3.AddAttribute(195, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 81 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                  UpdUserModel.Roles.AgenceRead

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(196, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(197);
                    __builder3.AddAttribute(198, "label", "Modification d\'agence");
                    __builder3.AddAttribute(199, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                      UpdUserModel.Roles.AgenceUpdt

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(200, "\r\n                                            ");
                    __builder3.OpenComponent<ForceT.Client.Pages.Utile.RolesUser.Role>(201);
                    __builder3.AddAttribute(202, "label", "Suppression d\'agence");
                    __builder3.AddAttribute(203, "bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
                                                                                     UpdUserModel.Roles.AgenceDlet

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(204, "\r\n                                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(205, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(207, "\r\n                            ");
                __builder2.AddMarkupContent(208, @"<div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                            </div>
                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(210, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(213, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\amine\source\repos\Force tracking\ForceT\Client\Pages\Utilisateur\DetailUtilisateur.razor"
       
    [Parameter]
    public RegisterModel UpdUserModel { get; set; }
    [Parameter]
    public Action DataChanged { get; set; }

    private async void HandleValidSubmit()
    {
        string adr21 = NavigationManager.BaseUri.ToString() + "api/Adresses/";// + adresse.AdresseId;
        //var result = await AuthService.PutJsonAsync<Adresse>(new Uri(adr21), /*adresse*/);
        await CloseTaskModal();
        DataChanged?.Invoke();
    }

    private async Task CloseTaskModal()
    {
        await JSRuntime.InvokeAsync<object>("JsFunctions.CloseModal", "DetailAdresse");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fee48fad6e00cf06b11cbf26a8e33aa48f3e743"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaUniversidad.FrontEnd.Pr0.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using SistemaUniversidad.FrontEnd.Pr0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using SistemaUniversidad.FrontEnd.Pr0.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\_Imports.razor"
using SistemaUniversidad.FrontEnd.Pr0.Dtos;

#line default
#line hidden
#nullable disable
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "sidebar");
            __builder.AddAttribute(2, "class", "sidebar sidebar-fixed expandable sidebar-light");
            __builder.AddAttribute(3, "data-backdrop", "true");
            __builder.AddAttribute(4, "data-dismiss", "true");
            __builder.AddAttribute(5, "data-swipe", "true");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar-inner");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "ace-scroll flex-grow-1 mt-1px");
            __builder.AddAttribute(10, "data-ace-scroll", "{}");
            __builder.OpenElement(11, "nav");
            __builder.AddAttribute(12, "class", "pt-3");
            __builder.AddAttribute(13, "aria-label", "Main");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column has-active-border");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item" + " " + (
#nullable restore
#line 11 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "nav-link");
            __builder.AddAttribute(20, "href", "/");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "<i class=\"nav-icon fa fa-home\"></i>\n                            ");
                __builder2.AddMarkupContent(23, "<span class=\"nav-text fadeable\">Inicio</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\n                    ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item" + " " + (
#nullable restore
#line 18 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Sedes", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "href", "/Sedes");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(32, "<span class=\"nav-text fadeable\">Sedes</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n                    ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item" + " " + (
#nullable restore
#line 25 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("CicloLectivo", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "href", "/CicloLectivo");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(41, "<span class=\"nav-text fadeable\">Ciclos Lectivos</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n                    ");
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "class", "nav-item" + " " + (
#nullable restore
#line 32 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Carreras", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "class", "nav-link");
            __builder.AddAttribute(47, "href", "/Carreras");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(50, "<span class=\"nav-text fadeable\">Carreras</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n\n                    ");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "nav-item" + " " + (
#nullable restore
#line 39 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Cursos", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddAttribute(56, "href", "/Cursos");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(59, "<span class=\"nav-text fadeable\">Cursos</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n                    ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "nav-item" + " " + (
#nullable restore
#line 46 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Aulas", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
            __builder.AddAttribute(64, "class", "nav-link");
            __builder.AddAttribute(65, "href", "/Aulas");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(67, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(68, "<span class=\"nav-text fadeable\">Aulas</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n\n                    ");
            __builder.OpenElement(70, "li");
            __builder.AddAttribute(71, "class", "nav-item" + " " + (
#nullable restore
#line 53 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Matricula", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
            __builder.AddAttribute(73, "class", "nav-link");
            __builder.AddAttribute(74, "href", "/Matricula");
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(77, "<span class=\"nav-text fadeable\">Matriculas</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n\n                    ");
            __builder.OpenElement(79, "li");
            __builder.AddAttribute(80, "class", "nav-item" + " " + (
#nullable restore
#line 60 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Profesores", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "class", "nav-link");
            __builder.AddAttribute(83, "href", "/Profesores");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(86, "<span class=\"nav-text fadeable\">Profesores</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n\n                    ");
            __builder.OpenElement(88, "li");
            __builder.AddAttribute(89, "class", "nav-item" + " " + (
#nullable restore
#line 67 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("Estudiantes", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(90);
            __builder.AddAttribute(91, "class", "nav-link");
            __builder.AddAttribute(92, "href", "/Estudiantes");
            __builder.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(94, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(95, "<span class=\"nav-text fadeable\">Estudiantes</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n\n                    ");
            __builder.OpenElement(97, "li");
            __builder.AddAttribute(98, "class", "nav-item" + " " + (
#nullable restore
#line 74 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("CursosEnMatriculas", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(99);
            __builder.AddAttribute(100, "class", "nav-link");
            __builder.AddAttribute(101, "href", "/CursosEnMatriculas");
            __builder.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(103, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(104, "<span class=\"nav-text fadeable\">Cursos En Matriculas</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n\n                    ");
            __builder.OpenElement(106, "li");
            __builder.AddAttribute(107, "class", "nav-item" + " " + (
#nullable restore
#line 81 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("CursosConProfesore", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(108);
            __builder.AddAttribute(109, "class", "nav-link");
            __builder.AddAttribute(110, "href", "/CursosConProfesore");
            __builder.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(112, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(113, "<span class=\"nav-text fadeable\">Cursos Con Profesores</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\n\n                    ");
            __builder.OpenElement(115, "li");
            __builder.AddAttribute(116, "class", "nav-item" + " " + (
#nullable restore
#line 88 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
                                         GetActive("CursosEnAula", NavLinkMatch.All)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(117);
            __builder.AddAttribute(118, "class", "nav-link");
            __builder.AddAttribute(119, "href", "/CursosEnAula");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(121, "<i class=\"nav-icon fa fa-tv\"></i>\n                            ");
                __builder2.AddMarkupContent(122, "<span class=\"nav-text fadeable\">Cursos En Aulas</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\SideBar.razor"
       

    [Inject]
    NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized() => NavigationManager.LocationChanged += (s, e) => StateHasChanged();

    bool IsActive(string href, NavLinkMatch navLinkMatch = NavLinkMatch.Prefix)
    {
        var relativePath = NavigationManager.ToBaseRelativePath(NavigationManager.Uri).ToLower();
        return navLinkMatch == NavLinkMatch.All ? relativePath == href.ToLower() : relativePath.StartsWith(href.ToLower());
    }

    string GetActive(string href, NavLinkMatch navLinkMatch = NavLinkMatch.Prefix) => IsActive(href, navLinkMatch) ? "active" : "na";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31fff2e3918d8585eec4e8e81535ab47c01fdcd3"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-lg navbar-fixed navbar-blue\" b-3huiqx7tbu><div class=\"navbar-inner\" b-3huiqx7tbu><div class=\"navbar-intro justify-content-xl-between\" b-3huiqx7tbu><button type=\"button\" class=\"btn btn-burger burger-arrowed static collapsed ml-2 d-flex d-xl-none\" data-toggle-mobile=\"sidebar\" data-target=\"#sidebar\" aria-controls=\"sidebar\" aria-expanded=\"false\" aria-label=\"Toggle sidebar\" b-3huiqx7tbu><span class=\"bars\" b-3huiqx7tbu></span></button>\n\n            <a class=\"navbar-brand text-white\" href=\"#\" b-3huiqx7tbu><i class=\"fa fa-leaf\" b-3huiqx7tbu></i>\n                <span b-3huiqx7tbu>UniSys</span></a>\n\n            <button type=\"button\" class=\"btn btn-burger mr-2 d-none d-xl-flex\" data-toggle=\"sidebar\" data-target=\"#sidebar\" aria-controls=\"sidebar\" aria-expanded=\"true\" aria-label=\"Toggle sidebar\" b-3huiqx7tbu><span class=\"bars\" b-3huiqx7tbu></span></button></div>\n\n        <button class=\"navbar-toggler ml-1 mr-2 px-1\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarMenu\" aria-controls=\"navbarMenu\" aria-expanded=\"false\" aria-label=\"Toggle navbar menu\" b-3huiqx7tbu><span class=\"pos-rel\" b-3huiqx7tbu><img class=\"border-2 brc-white-tp1 radius-round\" width=\"36\" src=\"assets/image/avatar/avatar6.jpg\" alt=\"Jason\'s Photo\" b-3huiqx7tbu>\n                <span class=\"bgc-warning radius-round border-2 brc-white p-1 position-tr mr-n1px mt-n1px\" b-3huiqx7tbu></span></span></button>\n\n        <div class=\"navbar-menu collapse navbar-collapse navbar-backdrop\" id=\"navbarMenu\" b-3huiqx7tbu><div class=\"navbar-nav\" b-3huiqx7tbu><ul class=\"nav\" b-3huiqx7tbu><li class=\"nav-item dropdown order-first order-lg-last\" b-3huiqx7tbu><a class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\" b-3huiqx7tbu><img id=\"id-navbar-user-image\" class=\"d-none d-lg-inline-block radius-round border-2 brc-white-tp1 mr-2 w-6\" src=\"assets/image/avatar/avatar6.jpg\" alt=\"Jason\'s Photo\" b-3huiqx7tbu>\n                            <span class=\"d-inline-block d-lg-none d-xl-inline-block\" b-3huiqx7tbu><span class=\"text-90\" id=\"id-user-welcome\" b-3huiqx7tbu>Bienvenido,</span>\n                                <span class=\"nav-user-name\" b-3huiqx7tbu>Josue</span></span>\n\n                            <i class=\"caret fa fa-angle-down d-none d-xl-block\" b-3huiqx7tbu></i>\n                            <i class=\"caret fa fa-angle-left d-block d-lg-none\" b-3huiqx7tbu></i></a>\n\n                        <div class=\"dropdown-menu dropdown-caret dropdown-menu-right dropdown-animated brc-primary-m3 py-1\" b-3huiqx7tbu><div class=\"d-none d-lg-block d-xl-none\" b-3huiqx7tbu><div class=\"dropdown-header\" b-3huiqx7tbu>\n                                    Bienvenido\n                                </div>\n                                <div class=\"dropdown-divider\" b-3huiqx7tbu></div></div>\n\n                            <a class=\"mt-1 dropdown-item btn btn-outline-grey bgc-h-primary-l3 btn-h-light-primary btn-a-light-primary\" href=\"html/page-profile.html\" b-3huiqx7tbu><i class=\"fa fa-user text-primary-m1 text-105 mr-1\" b-3huiqx7tbu></i>\n                                Perfil\n                            </a>\n\n                            <a class=\"dropdown-item btn btn-outline-grey bgc-h-success-l3 btn-h-light-success btn-a-light-success\" href=\"#\" data-toggle=\"modal\" data-target=\"#id-ace-settings-modal\" b-3huiqx7tbu><i class=\"fa fa-cog text-success-m1 text-105 mr-1\" b-3huiqx7tbu></i>\n                                Configuraciones\n                            </a>\n\n                            <div class=\"dropdown-divider brc-primary-l2\" b-3huiqx7tbu></div>\n\n                            <a class=\"dropdown-item btn btn-outline-grey bgc-h-secondary-l3 btn-h-light-secondary btn-a-light-secondary\" href=\"html/page-login.html\" b-3huiqx7tbu><i class=\"fa fa-power-off text-warning-d1 text-105 mr-1\" b-3huiqx7tbu></i>\n                                Salir\n                            </a></div></li></ul></div></div></div></nav>");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Shared\NavMenu.razor"
       
    private bool collapseSideBar = true;

    public string SideBarCssClass => collapseSideBar ? "collapsed" : null;

    private async Task ToggleNavMenu()
    {
        collapseSideBar = !collapseSideBar;

        await LogAsync("asdasd");
    }

    public async Task LogAsync(string message)
    {
        await JS.InvokeVoidAsync("console.log", "" + SideBarCssClass);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
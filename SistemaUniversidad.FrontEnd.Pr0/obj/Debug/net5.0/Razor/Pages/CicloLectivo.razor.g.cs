#pragma checksum "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca99cb2b2b80cc66420e4c6052a223061885dd4"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaUniversidad.FrontEnd.Pr0.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CicloLectivo")]
    public partial class CicloLectivo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>\r\n    Lista de Clicos Lectivos\r\n</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card dcard");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body px-1 px-md-3");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "autocomplete", "off");
            __builder.AddMarkupContent(7, @"<div class=""d-flex justify-content-between flex-column flex-sm-row mb-3 px-2 px-sm-0""><h3 class=""text-125 pl-1 mb-3 mb-sm-0 text-secondary-d4"">
                    Listado de Aulas
                </h3>

                <div class=""mb-2 mb-sm-0""><button type=""button"" class=""btn btn-blue px-3 d-block w-100 text-95 radius-round border-2 brc-black-tp10"" @*@onclick=""MostrarModalDeAgregar"" *@><i class=""fa fa-plus mr-1""></i>
                        Agregar <span class=""d-sm-none d-md-inline"">Aula</span></button></div></div>");
#nullable restore
#line 26 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
             if (ListaDeCicloLectivo == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>Cargando Listado De Aulas...</em></p>");
#nullable restore
#line 28 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                                                             }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "id", "simple-table");
            __builder.AddAttribute(11, "class", "mb-0 table table-borderless table-bordered-x brc-secondary-l3 text-dark-m2 radius-1 overflow-hidden");
            __builder.AddMarkupContent(12, @"<thead class=""text-dark-tp3 bgc-grey-l4 text-90 border-b-1 brc-transparent""><tr><th>Numero Ciclo</th>
                            <th>Nombre Ciclo</th>
                            <th>Fecha Inicio</th>
                            <th>Fecha Fin</th>
                            <th>Acciones</th></tr></thead>

                    ");
            __builder.OpenElement(13, "tbody");
            __builder.AddAttribute(14, "class", "mt-1");
#nullable restore
#line 44 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                         foreach (var Aula in ListaDeCicloLectivo)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.AddAttribute(16, "class", "bgc-h-yellow-l4 d-style");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "class", "text-600 text-dark");
            __builder.AddContent(19, 
#nullable restore
#line 47 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                                                            Aula.NumeroCiclo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "class", "text-600 text-orange-d2");
            __builder.AddContent(23, 
#nullable restore
#line 48 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                                                                 Aula.NombreCiclo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "class", "text-600 text-dark");
            __builder.AddContent(27, 
#nullable restore
#line 49 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                                                            Aula.FechaInicio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "text-600 text-orange-d2");
            __builder.AddContent(31, 
#nullable restore
#line 50 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                                                                 Aula.FechaFin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.AddMarkupContent(33, @"<td><div class=""d-none d-lg-flex""><button type=""button"" class=""mx-2px btn radius-1 border-2 btn-xs btn-brc-tp btn-light-secondary btn-h-lighter-success btn-a-lighter-success"" @*@onclick=""() => MostrarModalDeActualizar(Aula.NumeroAula)"" *@><i class=""fa fa-pencil-alt""></i></button>

                                    <button type=""button"" class=""mx-2px btn radius-1 border-2 btn-xs btn-brc-tp btn-light-secondary btn-h-lighter-danger btn-a-lighter-danger"" @*@onclick=""() => MostrarModalDeEliminar(Aula.NumeroAula)"" *@><i class=""fa fa-trash-alt""></i></button></div></td>");
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\CicloLectivo.razor"
       
    private CicloLectivoDto[] ListaDeCicloLectivo;//Acá se guardará la lista de aulas

    private string UtlHost = "https://localhost:44365/api";

    protected override async Task OnInitializedAsync() //Esto es lo primero que se ejecutará
    {
        await ObtenerAulas(); //con solo llamar a este método, ya se puede cargar la lista de aulas a nivel de la vista
    }

    private async Task ObtenerAulas()
    {
        ListaDeCicloLectivo = await Http.GetFromJsonAsync<CicloLectivoDto[]>($"{UtlHost}/CiclosLectivos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

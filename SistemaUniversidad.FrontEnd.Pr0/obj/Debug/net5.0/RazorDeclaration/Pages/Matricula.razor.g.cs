// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Matricula")]
    public partial class Matricula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 265 "C:\Users\andyj\Escritorio\Progra\Sistema Universidad\SistemaUniversidad.FrontEnd\SistemaUniversidad.FrontEnd.Pr0\Pages\Matricula.razor"
       
    private MatriculaDto[] ListaDeMatriculas;

    private MatriculaDto MatriculasDtoModel = new();


    private string AccionDeEdicion;

    private int MatriculasPorActualizar;

    private int MatriculasPorEliminar;

    private string UtlHost = "https://localhost:44365/api";

    protected override async Task OnInitializedAsync()
    {
        await ObtenerMatriculas();
    }


    private async Task MostrarModalDeAgregar()
    {

        AccionDeEdicion = "Agregar";
        MatriculasDtoModel = new();

        await JSRuntime.InvokeAsync<object>("global.openModal", "ModalEdicionDeMatriculas");
    }

    private async Task MostrarModalDeActualizar(int NumeroMatricula)
    {

        AccionDeEdicion = "Actualizar";

        await ObtenerMatriculasPorId(NumeroMatricula);

        MatriculasPorActualizar = NumeroMatricula;

        await JSRuntime.InvokeAsync<object>("global.openModal", "ModalEdicionDeMatriculas");

    }

    private async Task GuardarMatriculas()
    {
        if (AccionDeEdicion == "Agregar")
        {
            await AgregarMatriculas();
        }
        else
        {
            await ActualizarMatriculas();
        }
    }


    private async Task MostrarModalDeEliminar(int NumeroMatricula)
    {

        await ObtenerMatriculasPorId(NumeroMatricula);

        MatriculasPorEliminar = NumeroMatricula;

        await JSRuntime.InvokeAsync<object>("global.openModal", "ModalConfirmacionDeEliminacionDeMatriculas");
    }

    private async Task ConfirmarEliminacionDeMatriculas()
    {

        await EliminarMatriculas();

    }


    private async Task ObtenerMatriculas()
    {
        ListaDeMatriculas = await Http.GetFromJsonAsync<MatriculaDto[]>($"{UtlHost}/Matriculas");
    }

    private async Task ObtenerMatriculasPorId(int NumeroMatricula)
    {
        MatriculasDtoModel = await Http.GetFromJsonAsync<MatriculaDto>($"{UtlHost}/Matriculas/{NumeroMatricula}");

    }

    private async Task AgregarMatriculas()
    {
        var matricula = MatriculasDtoModel;

        using var response = await Http.PostAsJsonAsync($"{UtlHost}/Matriculas", matricula);

        if (response.IsSuccessStatusCode)
        {
            await JSRuntime.InvokeAsync<object>("global.closeModal", "ModalEdicionDeMatriculas");

            await ObtenerMatriculas();

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaExito", "Matriculas agregada correctamente");

        }
        else
        {
            string errorMessage = response.ReasonPhrase;
            Console.WriteLine($"Error: {errorMessage}");

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaError", "No se pudo agregar las Matriculas ");

        }
    }

    private async Task ActualizarMatriculas()
    {
        var matricula = MatriculasDtoModel;

        using var response = await Http.PutAsJsonAsync($"{UtlHost}/Matriculas/{MatriculasPorActualizar}", matricula);

        if (response.IsSuccessStatusCode)
        {
            await JSRuntime.InvokeAsync<object>("global.closeModal", "ModalEdicionDeMatriculas");

            await ObtenerMatriculas();

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaExito", "Matriculas actualizada correctamente");
        }
        else
        {
            string errorMessage = response.ReasonPhrase;
            Console.WriteLine($"Error: {errorMessage}");

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaError", "No se pudo actualizar las Matriculas ");

        }
    }

    private async Task EliminarMatriculas()
    {
        using var response = await Http.DeleteAsync($"{UtlHost}/Matriculas/{MatriculasPorEliminar}");

        if (response.IsSuccessStatusCode)
        {
            await JSRuntime.InvokeAsync<object>("global.closeModal", "ModalConfirmacionDeEliminacionDeMatriculas");

            await ObtenerMatriculas();

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaExito", "Matriculas eliminada correctamente");
        }
        else
        {
            string errorMessage = response.ReasonPhrase;
            Console.WriteLine($"Error: {errorMessage}");

            await JSRuntime.InvokeAsync<object>("global.mostrarAlertaError", "Error al eliminar la Matricula");

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

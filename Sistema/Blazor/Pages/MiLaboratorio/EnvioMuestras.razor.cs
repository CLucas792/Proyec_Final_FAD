using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MiLaboratorio
{
    public partial class EnvioMuestras
    {
        [Inject] private IExamenServicio examenServicio { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        private Examen examen = new Examen();
        private IEnumerable<Examen> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista = await examenServicio.GetListaPorEstadoAsync("Tomada");
        }

    }
}


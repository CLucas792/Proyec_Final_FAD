using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MiFactura
{
    public partial class Factura
    {
        [Inject] private IEstablecimientoServicio establecimientoServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        private Establecimiento establecimiento = new Establecimiento();
        private Cliente cliente = new Cliente();

        protected override async Task OnInitializedAsync()
        {

            establecimiento = await establecimientoServicio.UnicoRegistroAsync();

        }
    }
}
